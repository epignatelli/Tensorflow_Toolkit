using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput SerializeTensor(this TFGraph graph, TensorFlow.TFOutput tensor, string operName=null)
		{
			return graph.SerializeTensor(tensor, operName);
		}
	}
}
