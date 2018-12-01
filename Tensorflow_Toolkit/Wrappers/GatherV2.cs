using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput GatherV2(TFGraph graph, TensorFlow.TFOutput parameters, TensorFlow.TFOutput indices, TensorFlow.TFOutput axis, string operName=null)
		{
			return graph.GatherV2(parameters, indices, axis, operName);
		}
	}
}