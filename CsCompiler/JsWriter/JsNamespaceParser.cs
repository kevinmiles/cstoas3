namespace CsCompiler.JsWriter {
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Reflection;
	using System.Text;
	using CsParser;
	using Expressions;
	using Metaspec;
	using Tools;

	public sealed class JsNamespaceParser : INamespaceParser {
		private string _outputFolder;
		private readonly FactoryExpressionCreator _creator = new FactoryExpressionCreator();

		public JsNamespaceParser() {
			_creator.AddParser(typeof (CsBinaryExpression), new BinaryExpression());
			_creator.AddParser(typeof (CsArrayInitializer), new ArrayInitializer());
			_creator.AddParser(typeof (CsAsIsExpression), new AsIsExpression());
			_creator.AddParser(typeof (CsAssignmentExpression), new AssignmentExpression());
			_creator.AddParser(typeof (CsConditionalExpression), new ConditionalExpression());
			_creator.AddParser(typeof (CsLambdaExpression), new LambdaExpression());

			_creator.AddParser(typeof (CsTypeofExpression), new TypeofExpression());
			_creator.AddParser(typeof (CsThisAccess), new ThisAccess());
			_creator.AddParser(typeof (CsSizeofExpression), new SizeofExpression());
			_creator.AddParser(typeof (CsSimpleName), new SimpleName());
			_creator.AddParser(typeof (CsRefValueExpression), new RefTypeExpression());
			_creator.AddParser(typeof (CsRefTypeExpression), new RefTypeExpression());
			_creator.AddParser(typeof (CsQueryExpression), new QueryExpression());
			_creator.AddParser(typeof (CsQualifiedAliasMemberAccess), new QualifiedAliasMemberAccess());
			_creator.AddParser(typeof (CsPrimaryExpressionMemberAccess), new PrimaryExpressionMemberAccess());
			_creator.AddParser(typeof (CsPredefinedTypeMemberAccess), new PredefinedTypeMemberAccess());
			_creator.AddParser(typeof (CsPostIncrementDecrementExpression),
			                                   new PostIncrementDecrementExpression());
			_creator.AddParser(typeof (CsPointerMemberAccess), new PointerMemberAccess());
			_creator.AddParser(typeof (CsParenthesizedExpression), new ParenthesizedExpression());
			_creator.AddParser(typeof (CsNewObjectExpression), new NewObjectExpression());
			_creator.AddParser(typeof (CsNewArrayExpression), new NewArrayExpression());
			_creator.AddParser(typeof (CsMakeRefExpression), new MakeRefExpression());
			_creator.AddParser(typeof (CsLiteral), new Literal());
			_creator.AddParser(typeof (CsInvocationExpression), new InvocationExpression());
			_creator.AddParser(typeof (CsElementAccess), new ElementAccess());
			_creator.AddParser(typeof (CsDefaultValueExpression), new DefaultValueExpression());
			_creator.AddParser(typeof (CsCheckedExpression), new CheckedExpression());
			_creator.AddParser(typeof (CsBaseMemberAccess), new BaseMemberAccess());
			_creator.AddParser(typeof (CsBaseIndexerAccess), new BaseIndexerAccess());
			_creator.AddParser(typeof (CsArgListExpression), new ArgListExpression());
			_creator.AddParser(typeof (CsAnonymousObjectCreationExpression),
			                                   new AnonymousObjectCreationExpression());
			_creator.AddParser(typeof (CsAnonymousMethodExpression), new AnonymousMethodExpression());
			_creator.AddParser(typeof (CsCastUnaryExpression), new CastUnaryExpression());
			_creator.AddParser(typeof (CsOperatorUnaryExpression), new OperatorUnaryExpression());
			_creator.AddParser(typeof (CsPreIncrementDecrementExpression), new PreIncrementDecrementExpression());
		}

		public static string Using { get; private set; }

		#region INamespaceParser Members
		public void PreBuildEvents(ICsProject pProject, string pPathToCompiler, bool pDebug) {
			byte[] assemblyBuffer = File.ReadAllBytes(pPathToCompiler + @"\\flash\\flash.dll");
			IExternalAssemblyModule module = IExternalAssemblyModuleFactory.create(assemblyBuffer, pPathToCompiler);
			pProject.addExternalAssemblyModules(new[] { module }, false, null);
		}

		public void Parse(CsNamespace pNameSpace, IEnumerable<CsUsingDirective> pUsing, string pOutputFolder) {
			if (pNameSpace == null) {
				return;
			}

			_outputFolder = pOutputFolder;
			string name = getNamespace(pNameSpace);
			string packDir = pOutputFolder + name.Replace('.', '\\');
			Directory.CreateDirectory(packDir);
			CodeBuilder builder = new CodeBuilder();

			foreach (CsNode cn in pNameSpace.member_declarations) {
				builder.Append("package ");

				builder.Append(name);
				builder.AppendLineAndIndent(" {");

				StringBuilder usings = new StringBuilder();

				parseUsing(pUsing, usings);
				parseUsing(pNameSpace.using_directives, usings);
				Using = usings.ToString();

				builder.Append(usings);

				builder.AppendLine(ClassParser.IMPORT_MARKER);
				ImportStatementList.Init();

				CsClass csClass = cn as CsClass;

				if (csClass != null) {
					ClassParser.Parse(csClass, builder, _creator);
					if (ClassParser.IsExtension) {
						File.WriteAllText(packDir + "\\" + ClassParser.ExtensionName + ".as", builder.ToString());

					} else {
						File.WriteAllText(packDir + "\\" + csClass.identifier.identifier + ".as", builder.ToString());
					}

					builder.Length = 0;
					continue;
				}

				CsInterface csInterface = cn as CsInterface;
				if (csInterface != null) {
					InterfaceParser.Parse(csInterface, builder, _creator);
					File.WriteAllText(packDir + "\\" + csInterface.identifier.identifier + ".as", builder.ToString());
					builder.Length = 0;
					continue;
				}

				if (csClass == null) {
					throw new Exception("Unknown type");
				}
			}
		}

		public static string MainClassName { get; internal set; }

		public void PostBuildEvents(bool pDebug, Dictionary<string, string> pArguments, out string pOutput, out ICollection<Error> pErrors) {
			if (!pArguments.ContainsKey(@"FlexSdkPath")) {
				pOutput = string.Empty;
				pErrors = new List<Error>();
				return;
			}

			ProcessArguments process = new ProcessArguments();

			JsProjectBuilder builder = new JsProjectBuilder(pArguments[@"FlexSdkPath"]);
			pArguments.Remove(@"FlexSdkPath");

			process.AddArgument(Path.Combine(_outputFolder, MainClassName.Replace(".", "\\")+".as"));
			process.AddArgument("source-path", _outputFolder);

			if (pDebug) {
				process.AddArgument(@"debug", "true");
				process.AddArgument(@"omit-trace-statements", "false");
				process.AddArgument(@"verbose-stacktraces", "true");
			}

			foreach (var argument in pArguments) {
				process.AddArgument(argument.Key, argument.Value);
			}

			process.AddArgument("o", Path.Combine(_outputFolder, @"..\swf\file.swf"));

			pErrors = builder.Compile(_outputFolder, process.ToString(), false, out pOutput);
		}

		#endregion

		private static string getNamespace(CsNamespace pNamespace) {
			string name = pNamespace.qualified_identifier.Aggregate(string.Empty,
			                                                        (pCurrent, pIdentifier) =>
			                                                        pCurrent + (pIdentifier.identifier.identifier + "."));
			return name.Substring(0, name.Length - 1);
		}

		private static void parseUsing(IEnumerable<CsUsingDirective> pNn, StringBuilder pStrb) {
			if (pNn == null) {
				return;
			}

			foreach (CsUsingDirective directive in pNn) {
				if (directive is CsUsingNamespaceDirective) {
					string name = JsHelpers.Convert(Helpers.GetType(directive));
					if (name.StartsWith("flash.Global", StringComparison.Ordinal) ||
						//name.StartsWith("System", StringComparison.Ordinal) ||
						name.Equals("flash.", StringComparison.Ordinal)) {
						continue;
					}

					pStrb.AppendFormat("import {0}*;", name);
					pStrb.AppendLine();
					continue;
				}

				if (directive is CsUsingAliasDirective) {
					string name = JsHelpers.Convert(Helpers.GetType(directive));
					if (name.StartsWith("flash.Global", StringComparison.Ordinal) || name.Equals("flash.", StringComparison.Ordinal)) {
						continue;
					}

					pStrb.AppendFormat("import {0}*;", name);
					pStrb.AppendLine();
					continue;
				}

				throw new Exception(@"Unhandled using type");
			}
		}
	}
}
