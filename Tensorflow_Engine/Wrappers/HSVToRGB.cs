using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput HSVToRGB(this TFGraph graph, TensorFlow.TFOutput images, string operName=null)
		{
			return graph.HSVToRGB(images, operName);
		}
	}
}
