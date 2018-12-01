using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput AdjustSaturation(this TFGraph graph, TensorFlow.TFOutput images, TensorFlow.TFOutput scale, string operName=null)
		{
			return graph.AdjustSaturation(images, scale, operName);
		}
	}
}
