using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation GcsConfigureCredentials(this TFGraph graph, TensorFlow.TFOutput json, string operName=null)
		{
			return graph.GcsConfigureCredentials(json, operName);
		}
	}
}
