using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizedMaxPool(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput min_input, TensorFlow.TFOutput max_input, long[] ksize, long[] strides, string padding, string operName=null)
		{
			return graph.QuantizedMaxPool(input, min_input, max_input, ksize, strides, padding, operName);
		}
	}
}
