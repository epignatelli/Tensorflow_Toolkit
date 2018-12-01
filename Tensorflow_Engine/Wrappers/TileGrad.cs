using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TileGrad(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput multiples, string operName=null)
		{
			return graph.TileGrad(input, multiples, operName);
		}
	}
}
