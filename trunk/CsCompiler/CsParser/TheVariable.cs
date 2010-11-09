
namespace CsCompiler.CsParser {
	using System.Collections.Generic;
	using Interfaces;
	using Metaspec;
	using Tools;

	public sealed class TheVariable : BaseNode {
		internal TheVariable(CsVariableDeclaration pCsVariableDeclaration, TheClass pTheClass) {
			Modifiers.AddRange(Helpers.GetModifiers(pCsVariableDeclaration.modifiers));

			foreach (CsVariableDeclarator declarator in pCsVariableDeclaration.declarators) {
				Variable v = new Variable {
					//RealName = declarator.identifier.identifier,
					//Name = Helpers.GetRealName(declarator, declarator.identifier.identifier),
					Name = declarator.identifier.identifier,
					Initializer =
						declarator.initializer == null ? null : FactoryExpressionCreator.Parse(declarator.initializer as CsExpression),
					ReturnType = Helpers.GetType(declarator.entity.type)
				};

				v.Modifiers.AddRange(Modifiers);
				Variables.Add(v);
			}
		}

		public readonly List<Variable> Variables = new List<Variable>();
	}

	public sealed class Variable : BaseNode, ICsHasReturnType {
		public Expression Initializer;

		public string ReturnType {
			get; internal set; }
	}
}
