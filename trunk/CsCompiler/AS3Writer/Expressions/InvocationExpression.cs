namespace CsCompiler.AS3Writer.Expressions {
	using System;
	using System.Collections.Generic;
	using CsParser;
	using Metaspec;
	using Tools;

	public class InvocationExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement) {
			CsInvocationExpression ex = (CsInvocationExpression)pStatement;

			List<string> indexes = new List<string>();
			
			if (ex.argument_list != null) {
				foreach (CsArgument argument in ex.argument_list.list) {
					indexes.Add(FactoryExpressionCreator.Parse(argument.expression).Value);
				}
			}

			TheClass c = TheClassFactory.Get(pStatement);
			TheMethod m;

			CsEntityMethod method = ex.entity as CsEntityMethod;
			CsEntityDelegate entityDelegate = ex.entity as CsEntityDelegate;

			string name = FactoryExpressionCreator.Parse(ex.expression).Value;

			//call es de tipo super. Necesito saber cuál es la clase heredada)
			if (name.EndsWith("super.", StringComparison.Ordinal)) {
				c = c.Base;
				m = c.GetMethod(method);
				name = name + m.Name;

			} else if (method != null) {
				//si es una expresión de tipo xx.yy.method(), tengo que revisar la expresión
				//porque la invocación se da como expresión completa...
				c = TheClassFactory.Get(method.parent);
				m = c.GetMethod(method);

				if (m.IsExtensionMethod) {
					int fnIndex = name.IndexOf(m.Name);
					if (fnIndex > 0)
						fnIndex--;

					indexes.Insert(0, name.Substring(0, fnIndex));
					name = m.FullName;

				} else {
					name = name.Replace(m.Name, m.Name);
				}

			} else if (entityDelegate != null) {
				//es un evento?
				if (ex.expression.ec == expression_classification.ec_event_access) {
					TheEvent theEvent = c.GetEvent(name);
					if (theEvent.IsFlashEvent) {
						name = "dispatchEvent";

					} else {
						name += ".fire";
					}
				}
			} 

			//patch
			if (name.Contains("{0}")) {
				//patch for "delete(object)"
				if (name.Contains("*")) {
					int dot = name.LastIndexOf(".");
					int star = name.IndexOf("*", StringComparison.Ordinal) + 1;

					string arg0 = dot == -1 ? string.Empty : name.Substring(0, dot);

					name = string.Format(name.Substring(star), arg0, indexes[0]);
					
				} else {
					string p = indexes[0];
					indexes.RemoveAt(0);
					name = string.Format(name, p, string.Join(", ", indexes.ToArray()));	
				}

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
