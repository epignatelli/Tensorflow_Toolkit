using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static TensorFlow.TFOperation ReaderRestoreStateV2(TFGraph graph, TensorFlow.TFOutput reader_handle, TensorFlow.TFOutput state, string operName=null)
		{
			return graph.ReaderRestoreStateV2(reader_handle, state, operName);
		}
	}
}