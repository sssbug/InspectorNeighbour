using System;
using UnityEngine;

namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	public class MemoryCounterData : BaseCounterData
	{
		public uint lastTotalValue;
		public uint lastAllocatedValue;
		public long lastMonoValue;
		[SerializeField]
		private float updateInterval;
		[SerializeField]
		private bool preciseValues;
		[SerializeField]
		private bool totalReserved;
		[SerializeField]
		private bool allocated;
		[SerializeField]
		private bool monoUsage;
	}
}
