using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput FakeQuantWithMinMaxArgsGradient(this TFGraph graph, TensorFlow.TFOutput gradients, TensorFlow.TFOutput inputs, System.Single? min=null, System.Single? max=null, long? num_bits=null, System.Boolean? narrow_range=null, string operName=null)
		{
			return graph.FakeQuantWithMinMaxArgsGradient(gradients, inputs, min, max, num_bits, narrow_range, operName);
		}
	}
}
