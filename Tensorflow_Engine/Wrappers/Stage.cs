using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation Stage(this TFGraph graph, TensorFlow.TFOutput[] values, long? capacity=null, long? memory_limit=null, string container=null, string shared_name=null, string operName=null)
		{
			return graph.Stage(values, capacity, memory_limit, container, shared_name, operName);
		}
	}
}
