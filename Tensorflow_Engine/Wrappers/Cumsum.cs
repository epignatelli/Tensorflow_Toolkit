using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Cumsum(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput axis, System.Boolean? exclusive=null, System.Boolean? reverse=null, string operName=null)
		{
			return graph.Cumsum(x, axis, exclusive, reverse, operName);
		}
	}
}
