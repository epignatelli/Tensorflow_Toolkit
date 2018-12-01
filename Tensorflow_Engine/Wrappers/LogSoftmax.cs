using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput LogSoftmax(this TFGraph graph, TensorFlow.TFOutput logits, string operName=null)
		{
			return graph.LogSoftmax(logits, operName);
		}
	}
}
