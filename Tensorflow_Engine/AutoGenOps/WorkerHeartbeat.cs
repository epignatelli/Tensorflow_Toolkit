using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput WorkerHeartbeat(this TFGraph graph, TensorFlow.TFOutput request, string operName=null)
		{
			return graph.WorkerHeartbeat(request, operName);
		}
	}
}
