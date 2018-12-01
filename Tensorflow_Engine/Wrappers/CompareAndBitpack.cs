using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CompareAndBitpack(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput threshold, string operName=null)
		{
			return graph.CompareAndBitpack(input, threshold, operName);
		}
	}
}
