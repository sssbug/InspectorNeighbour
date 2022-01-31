using System;
using UnityEngine;
using CodeStage.AdvancedFPSCounter.Labels;

namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	public class BaseCounterData
	{
		[SerializeField]
		protected bool enabled;
		[SerializeField]
		protected LabelAnchor anchor;
		[SerializeField]
		protected Color color;
	}
}
