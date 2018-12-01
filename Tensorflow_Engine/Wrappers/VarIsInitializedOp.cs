using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput VarIsInitializedOp(this TFGraph graph, TensorFlow.TFOutput resource, string operName=null)
		{
			return graph.VarIsInitializedOp(resource, operName);
		}
	}
}
