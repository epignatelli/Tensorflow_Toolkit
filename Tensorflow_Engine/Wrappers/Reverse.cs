using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Reverse(this TFGraph graph, TensorFlow.TFOutput tensor, TensorFlow.TFOutput dims, string operName=null)
		{
			return graph.Reverse(tensor, dims, operName);
		}
	}
}
