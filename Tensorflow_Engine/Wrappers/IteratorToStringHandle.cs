using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput IteratorToStringHandle(this TFGraph graph, TensorFlow.TFOutput resource_handle, string operName=null)
		{
			return graph.IteratorToStringHandle(resource_handle, operName);
		}
	}
}
