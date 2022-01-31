using System;
using UnityEngine;

namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	public class FPSCounterData : BaseCounterData
	{
		public int warningLevelValue;
		public int criticalLevelValue;
		public bool resetAverageOnNewScene;
		public bool resetMinMaxOnNewScene;
		public int minMaxIntervalsToSkip;
		public int lastValue;
		public float lastMillisecondsValue;
		public int lastAverageValue;
		public int lastMinimumValue;
		public int lastMaximumValue;
		[SerializeField]
		private float updateInterval;
		[SerializeField]
		private bool showMilliseconds;
		[SerializeField]
		private bool showAverage;
		[SerializeField]
		private int averageFromSamples;
		[SerializeField]
		private bool showMinMax;
		[SerializeField]
		private bool minMaxOnNewLine;
		[SerializeField]
		private Color colorWarning;
		[SerializeField]
		private Color colorCritical;
	}
}
