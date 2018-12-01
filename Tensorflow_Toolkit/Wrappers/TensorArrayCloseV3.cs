using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation TensorArrayCloseV3(TFGraph graph, TensorFlow.TFOutput handle, string operName=null)
		{
			return graph.TensorArrayCloseV3(handle, operName);
		}
	}
}