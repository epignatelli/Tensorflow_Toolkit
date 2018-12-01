using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FFT2D(TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.FFT2D(input, operName);
		}
	}
}