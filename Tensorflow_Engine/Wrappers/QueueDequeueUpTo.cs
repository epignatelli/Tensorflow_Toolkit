using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput[] QueueDequeueUpTo(this TFGraph graph, TensorFlow.TFOutput handle, TensorFlow.TFOutput n, TensorFlow.TFDataType[] component_types, long? timeout_ms=null, string operName=null)
		{
			return graph.QueueDequeueUpTo(handle, n, component_types, timeout_ms, operName);
		}
	}
}
