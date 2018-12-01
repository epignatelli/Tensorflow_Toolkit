using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput RefIdentity(TFGraph graph, TensorFlow.TFOutput input, string operName=null)
		{
			return graph.RefIdentity(input, operName);
		}
	}
}