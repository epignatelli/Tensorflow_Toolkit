using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> FusedBatchNormV2(this TFGraph graph, TensorFlow.TFOutput x, TensorFlow.TFOutput scale, TensorFlow.TFOutput offset, TensorFlow.TFOutput mean, TensorFlow.TFOutput variance, System.Single? epsilon=null, string data_format=null, System.Boolean? is_training=null, string operName=null)
		{
			return graph.FusedBatchNormV2(x, scale, offset, mean, variance, epsilon, data_format, is_training, operName);
		}
	}
}
