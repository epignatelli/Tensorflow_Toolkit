using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput PreventGradient(this TFGraph graph, TensorFlow.TFOutput input, string message=null, string operName=null)
		{
			return graph.PreventGradient(input, message, operName);
		}
	}
}
