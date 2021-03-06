using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation InfeedEnqueueTuple(this TFGraph graph, TensorFlow.TFOutput[] inputs, TensorFlow.TFShape[] shapes, long? device_ordinal=null, string operName=null)
		{
			return graph.InfeedEnqueueTuple(inputs, shapes, device_ordinal, operName);
		}
	}
}
