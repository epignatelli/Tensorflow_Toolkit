using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StringJoin(this TFGraph graph, TensorFlow.TFOutput[] inputs, string separator=null, string operName=null)
		{
			return graph.StringJoin(inputs, separator, operName);
		}
	}
}
