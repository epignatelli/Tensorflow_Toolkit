using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CheckNumerics(this TFGraph graph, TensorFlow.TFOutput tensor, string message, string operName=null)
		{
			return graph.CheckNumerics(tensor, message, operName);
		}
	}
}
