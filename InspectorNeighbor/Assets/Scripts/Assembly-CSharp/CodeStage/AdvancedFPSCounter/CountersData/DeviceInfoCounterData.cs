using System;
using UnityEngine;

namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	public class DeviceInfoCounterData : BaseCounterData
	{
		public string lastValue;
		[SerializeField]
		private bool cpuModel;
		[SerializeField]
		private bool gpuModel;
		[SerializeField]
		private bool ramSize;
		[SerializeField]
		private bool screenData;
	}
}
