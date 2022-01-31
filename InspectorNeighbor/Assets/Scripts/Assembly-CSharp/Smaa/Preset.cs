using System;

namespace Smaa
{
	[Serializable]
	public class Preset
	{
		public bool DiagDetection;
		public bool CornerDetection;
		public float Threshold;
		public float DepthThreshold;
		public int MaxSearchSteps;
		public int MaxSearchStepsDiag;
		public int CornerRounding;
		public float LocalContrastAdaptationFactor;
	}
}
