using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput UnsortedSegmentMax(this TFGraph graph, TensorFlow.TFOutput data, TensorFlow.TFOutput segment_ids, TensorFlow.TFOutput num_segments, string operName=null)
		{
			return graph.UnsortedSegmentMax(data, segment_ids, num_segments, operName);
		}
	}
}
