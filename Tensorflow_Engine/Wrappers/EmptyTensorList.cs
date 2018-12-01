using System;
using TensorFlow;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput EmptyTensorList(this TFGraph graph, TensorFlow.TFOutput element_shape, TensorFlow.TFDataType element_dtype, string operName=null)
		{
			return graph.EmptyTensorList(element_shape, element_dtype, operName);
		}
	}
}
