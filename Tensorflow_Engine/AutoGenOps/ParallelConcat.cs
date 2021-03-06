using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ParallelConcat(this TFGraph graph, TensorFlow.TFOutput[] values, TensorFlow.TFShape shape, string operName=null)
		{
			return graph.ParallelConcat(values, shape, operName);
		}
	}
}
