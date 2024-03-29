﻿namespace CsCompiler.AS3Writer.Expressions {
	using System;
	using CsParser;
	using Metaspec;
	using Tools;

	public sealed class AssignmentExpression : IExpressionParser {
		public Expression Parse(CsExpression pStatement, FactoryExpressionCreator pCreator) {
			CsAssignmentExpression ex = (CsAssignmentExpression)pStatement;

			Expression left = pCreator.Parse(ex.lhs);
			Expression right = pCreator.Parse(ex.rhs);

			if (((ex.lhs is CsElementAccess) || (ex.lhs is CsPrimaryExpressionMemberAccess)) && left.InternalType) {
				switch (ex.oper) {
					case CsTokenType.tkASSIGN:
						return new Expression(string.Format(left.Value, right.Value), pStatement.entity_typeref);

					case CsTokenType.tkPLUS_EQ:
					case CsTokenType.tkMINUS_EQ:
					case CsTokenType.tkDIV_EQ:
					case CsTokenType.tkMUL_EQ:
						string getter = ElementAccessHelper.parseElementAccess(ex.lhs, true, false, pCreator).Value;
						return new Expression(string.Format(left.Value, getter + As3Helpers.ConvertTokens(Helpers.GetTokenType(convertToken(ex.oper))) + right.Value), pStatement.entity_typeref);
				}
			}

			if ((ex.lhs is CsSimpleName) && left.InternalType) {
				switch (ex.oper) {
					case CsTokenType.tkASSIGN:
						return new Expression(string.Format(left.Value, right.Value), pStatement.entity_typeref);

					case CsTokenType.tkPLUS_EQ:
					case CsTokenType.tkMINUS_EQ:
					case CsTokenType.tkDIV_EQ:
					case CsTokenType.tkMUL_EQ:
						string getter = SimpleNameHelper.ParseSimpleName(ex.lhs, true, false).Value;
						return new Expression(string.Format(left.Value, getter + As3Helpers.ConvertTokens(Helpers.GetTokenType(convertToken(ex.oper))) + right.Value), pStatement.entity_typeref);
				}
			}

			if (ex.lhs is CsPrimaryExpressionMemberAccess) {
				if (ex.lhs.ec == expression_classification.ec_event_access) {
					CsEntityEvent ev = (CsEntityEvent)ex.lhs.entity;

					TheClass theClass = TheClassFactory.Get(ev.parent, pCreator);
					string eventName;
					//flash event on flash.xxxx
					if (theClass == null) {
						eventName = Helpers.GetEventFromAttr(ev.attributes);

						return new Expression(
							left.Value +
							(ex.oper == CsTokenType.tkPLUS_EQ ?
							("addEventListener(" + eventName + ", " + right.Value + ", false, 0, true)") :
							("removeEventListener(" + eventName + ", " + right.Value + ")"))
							, pStatement.entity_typeref
						);
					}

					TheEvent theEvent = theClass.GetEvent(ev.name);

					if (theEvent != null && string.IsNullOrEmpty(theEvent.EventName)) {//custom event on the same class
						return new Expression(
							//event name == left => left IS the event name. Do not add twice
							left.Value + (ev.name.Equals(left.Value, StringComparison.Ordinal) ? string.Empty : ev.name) +
							(ex.oper == CsTokenType.tkPLUS_EQ ? ".add" : ".remove") +
							"(" + right.Value + ")"
							, pStatement.entity_typeref
						);
					}

					eventName = theEvent == null ? Helpers.GetEventFromAttr(ev.attributes) : theEvent.EventName;

					//flash event on the same class.
					return new Expression(
						//event name == left => left IS the event name. Do not add twice
						(ev.name.Equals(left.Value, StringComparison.Ordinal) ? string.Empty : left.Value) +
						(ex.oper == CsTokenType.tkPLUS_EQ
							? ("addEventListener(" + eventName + ", " + right.Value + ", false, 0, true)")
							: ("removeEventListener(" + eventName + ", " + right.Value + ")"))
						, pStatement.entity_typeref);
				} 
				//else {
				//    left = FactoryExpressionCreator.Parse(ex.lhs);
				//    CsPrimaryExpressionMemberAccess primaryExpressionMemberAccess = (CsPrimaryExpressionMemberAccess)ex.lhs;
				//    TheClass theClass = TheClassFactory.Get((CsEntity)primaryExpressionMemberAccess.entity);
				//    //TheProperty theProp = theClass.GetProperty();
				//}
			}

			

			return new Expression(string.Format("{0} {2} {1}", left.Value, right.Value, As3Helpers.ConvertTokens(Helpers.GetTokenType(ex.oper))), pStatement.entity_typeref);
		}

		private static CsTokenType convertToken(CsTokenType pInToken) {
			switch (pInToken) {
				case CsTokenType.tkPLUS_EQ:
					return CsTokenType.tkPLUS;

				case CsTokenType.tkMINUS_EQ:
					return CsTokenType.tkMINUS;

				case CsTokenType.tkDIV_EQ:
					return CsTokenType.tkDIV;

				case CsTokenType.tkMUL_EQ:
					return CsTokenType.tkSTAR;

				case CsTokenType.tkMOD_EQ:
					return CsTokenType.tkMOD;

				default:
					throw new Exception();
			}
		}
	}
}
