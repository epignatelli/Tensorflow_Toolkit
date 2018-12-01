using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorArrayScatterV3(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput indices, TensorFlow.TFOutput value, TensorFlow.TFOutput flow_in, string operName=null)
		{
			return graph.TensorArrayScatterV3(handle, indices, value, flow_in, operName);
		}
	}
}
