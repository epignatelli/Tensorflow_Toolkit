using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RepeatDataset(this TFGraph graph, TensorFlow.TFOutput input_dataset, TensorFlow.TFOutput count, TensorFlow.TFDataType[] output_types, TensorFlow.TFShape[] output_shapes, string operName=null)
		{
			return graph.RepeatDataset(input_dataset, count, output_types, output_shapes, operName);
		}
	}
}
