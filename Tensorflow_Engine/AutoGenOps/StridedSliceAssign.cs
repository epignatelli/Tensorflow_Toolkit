using System;
using TensorFlow;
using System.Collections.Generic;

namespace BH.Engine.Tensorflow
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput StridedSliceAssign(this TFGraph graph, TensorFlow.TFOutput reference, TensorFlow.TFOutput begin, TensorFlow.TFOutput end, TensorFlow.TFOutput strides, TensorFlow.TFOutput value, long? begin_mask=null, long? end_mask=null, long? ellipsis_mask=null, long? new_axis_mask=null, long? shrink_axis_mask=null, string operName=null)
		{
			return graph.StridedSliceAssign(reference, begin, end, strides, value, begin_mask, end_mask, ellipsis_mask, new_axis_mask, shrink_axis_mask, operName);
		}
	}
}
