using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOutput CropAndResizeGradBoxes(TFGraph graph, TensorFlow.TFOutput grads, TensorFlow.TFOutput image, TensorFlow.TFOutput boxes, TensorFlow.TFOutput box_ind, string method=null, string operName=null)
		{
			return graph.CropAndResizeGradBoxes(grads, image, boxes, box_ind, method, operName);
		}
	}
}