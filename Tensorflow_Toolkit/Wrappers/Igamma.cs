using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Igamma(TFGraph graph, TensorFlow.TFOutput a, TensorFlow.TFOutput x, string operName=null)
		{
			return graph.Igamma(a, x, operName);
		}
	}
}