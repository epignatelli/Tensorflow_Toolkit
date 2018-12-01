using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StatsAggregatorSummary(this TFGraph graph, TensorFlow.TFOutput iterator, string operName=null)
		{
			return graph.StatsAggregatorSummary(iterator, operName);
		}
	}
}
