using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput TensorListLength(this TFGraph graph, TensorFlow.TFOutput input_handle, string operName=null)
		{
			return graph.TensorListLength(input_handle, operName);
		}
	}
}
