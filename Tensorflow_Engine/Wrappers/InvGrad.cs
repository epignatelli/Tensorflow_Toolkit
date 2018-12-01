using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput InvGrad(this TFGraph graph, TensorFlow.TFOutput y, TensorFlow.TFOutput dy, string operName=null)
		{
			return graph.InvGrad(y, dy, operName);
		}
	}
}
