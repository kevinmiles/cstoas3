namespace CsCompiler.JsWriter.Expressions {
	using System;
	using System.Collections.Generic;
	using CsParser;
	using Metaspec;
	using Tools;

	public sealed class InvocationExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsInvocationExpression ex = (CsInvocationExpression)pStatement;

			List<string> indexes = new List<string>();

			if (ex.argument_list != null) {
				foreach (CsArgument argument in ex.argument_list.list) {
					indexes.Add(pCreator.Parse(argument.expression).Value);
				}
			}

			TheClass c = TheClassFactory.Get(pStatement, pCreator);
			TheMethod m;

			CsEntityMethod method = ex.entity as CsEntityMethod;
			CsEntityDelegate entityDelegate = ex.entity as CsEntityDelegate;

			string name = pCreator.Parse(ex.expression).Value;

			//call es de tipo super. Necesito saber cuál es la clase heredada)
			if (name.EndsWith("super.", StringComparison.Ordinal)) {
				c = c.Base;
				m = c.GetMethod(method, pCreator);
				name = name + m.Name;

			} else if (method != null) {
				//si es una expresión de tipo xx.yy.method(), tengo que revisar la expresión
				//porque la invocación se da como expresión completa...
				c = TheClassFactory.Get(method.parent, pCreator);
				m = c.GetMethod(method, pCreator);

				if (m.IsExtensionMethod) {
					int fnIndex = name.IndexOf(m.Name);
					if (fnIndex > 0)
						fnIndex--;

					indexes.Insert(0, name.Substring(0, fnIndex));

					if (Helpers.HasAttribute(((CsEntityClass)method.parent).attributes, "JsExtensionAttribute")) {
						name = m.MyClass.FullName;
						name = name.Substring(0, name.LastIndexOf('.'));
						name = name + "."+m.Name;
						ImportStatementList.AddImport(name);
						name = m.Name;

					} else {
						name = m.FullName;
					}

				} else {
					name = name.Replace(m.Name, m.Name);
				}

			} else if (entityDelegate != null) {
				//es un evento?
				if (ex.expression.ec == expression_classification.ec_event_access) {
					TheEvent theEvent = c.GetEvent(name);
					name = theEvent.IsFlashEvent ?
								"dispatchEvent" :
								string.Format(@"if (_e{0}) _e{0}.fire", name);
				}
			}

			//patch
			if (name.Contains("{0}")) {
				string p = indexes[0];
				indexes.RemoveAt(0);
				name = string.Format(name, p, string.Join(", ", indexes.ToArray()));

			} else {
				name = name + "(" + string.Join(", ", indexes.ToArray()) + ")";
			}

			return new Expression(
				name,
				ex.entity_typeref
			);
		}
	}
}
