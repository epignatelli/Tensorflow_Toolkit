using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ConsumeMutexLock(this TFGraph graph, TensorFlow.TFOutput mutex_lock, string operName=null)
		{
			return graph.ConsumeMutexLock(mutex_lock, operName);
		}
	}
}
