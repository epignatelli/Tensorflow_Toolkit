using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeBmp(this TFGraph graph, TensorFlow.TFOutput contents, long? channels=null, string operName=null)
		{
			return graph.DecodeBmp(contents, channels, operName);
		}
	}
}
