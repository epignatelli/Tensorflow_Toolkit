using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput HistogramSummary(this TFGraph graph, TensorFlow.TFOutput tag, TensorFlow.TFOutput values, string operName=null)
		{
			return graph.HistogramSummary(tag, values, operName);
		}
	}
}
