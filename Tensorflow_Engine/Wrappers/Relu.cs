using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput Relu(this TFGraph graph, TensorFlow.TFOutput features, string operName=null)
		{
			return graph.Relu(features, operName);
		}
	}
}
