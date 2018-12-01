using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Softmax(this TFGraph graph, TensorFlow.TFOutput logits, string operName=null)
		{
			return graph.Softmax(logits, operName);
		}
	}
}
