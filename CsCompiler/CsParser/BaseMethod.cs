namespace CsCompiler.CsParser {
	using System.Collections.Generic;
	using System.Linq;
	using Metaspec;
	using Tools;

	public class BaseMethod : BaseNode {
		internal bool _isUnique = true;
		internal int _index;
		public TheClass MyClass { get; protected set; }
		public string Signature { get; protected set; }
		public CsBlock CodeBlock { get; protected set; }
		public List<TheMethodArgument> Arguments { get; protected set; }

		internal static List<TheMethodArgument> getArguments(CsEntityFormalParameter[] pCsEntityFormalParameter) {
			List<TheMethodArgument> arguments = new List<TheMethodArgument>();

			if (pCsEntityFormalParameter != null) {
				foreach (CsEntityFormalParameter formalParameter in pCsEntityFormalParameter) {
					CsFormalParameter p = formalParameter.param;

					arguments.Add(new TheMethodArgument {
						Name = p == null ? formalParameter.name : p.identifier.identifier,
						Type = Helpers.GetType(formalParameter.type),
						DefaultValue = p == null ? null : p.default_argument == null ? null : FactoryExpressionCreator.Parse(p.default_argument.expression)
					});
				}
			}

			return arguments;
		}

		internal static List<TheMethodArgument> getArguments(IEnumerable<CsFormalParameter> pLinkedList) {
			List<TheMethodArgument> arguments = new List<TheMethodArgument>();

			if (pLinkedList != null) {
				arguments.AddRange(from param in pLinkedList
				                   let e = param.default_argument == null ? null : FactoryExpressionCreator.Parse(param.default_argument.expression)
				                   select new TheMethodArgument {
				                   	Name = param.identifier.identifier,
									Type = Helpers.GetType(param.type), 
									DefaultValue = e
				                   });
			}

			return arguments;
		}

		internal static string getSignature(List<TheMethodArgument> pArguments) {
			return string.Join("_", pArguments.Select(pTheMethodArgument => pTheMethodArgument.Type).ToArray());
		}
	}
}
