using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput DecodeJSONExample(this TFGraph graph, TensorFlow.TFOutput json_examples, string operName=null)
		{
			return graph.DecodeJSONExample(json_examples, operName);
		}
	}
}
