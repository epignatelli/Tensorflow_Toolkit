using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Conv3DBackpropInput(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput filter, TensorFlow.TFOutput out_backprop, long[] strides, string padding, long[] dilations=null, string operName=null)
		{
			return graph.Conv3DBackpropInput(input, filter, out_backprop, strides, padding, dilations, operName);
		}
	}
}
