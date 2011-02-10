﻿using System;
using System.Collections.Generic;

namespace MetaCreator
{
	///<summary>
	/// Allows you to evaluate and run code in another app domain
	///</summary>
	public class AnotherAppDomApi : MarshalByRefObject
	{
		internal EvaluationResult EvaluateGeneratorCore(string code, bool isExpression, IEnumerable<string> additionalReferences, IEnumerable<string> additionalNamespaces)
		{
			return Evaluator.EvaluateGeneratorCore(code, isExpression, additionalReferences, additionalNamespaces);
		}

	}
}