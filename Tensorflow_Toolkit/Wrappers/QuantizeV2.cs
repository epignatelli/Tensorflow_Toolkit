using System;
using TensorFlow;

namespace BH.Engine.Deeplearning
{
public static partial class Compute
	{
		public static ValueTuple<TensorFlow.TFOutput,TensorFlow.TFOutput,TensorFlow.TFOutput> QuantizeV2(TFGraph graph, TensorFlow.TFOutput input, TensorFlow.TFOutput min_range, TensorFlow.TFOutput max_range, TensorFlow.TFDataType T, string mode=null, string round_mode=null, string operName=null)
		{
			return graph.QuantizeV2(input, min_range, max_range, T, mode, round_mode, operName);
		}
	}
}