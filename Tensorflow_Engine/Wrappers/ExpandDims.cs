using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput ExpandDims(this TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput dim, string operName=null)
		{
			return graph.ExpandDims(input, dim, operName);
		}
	}
}
