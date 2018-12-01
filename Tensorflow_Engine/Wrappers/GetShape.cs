using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static long[] GetShape(this TFGraph graph, TensorFlow.TFOutput output, TensorFlow.TFStatus status=null)
		{
			return graph.GetShape(output, status);
		}
	}
}
