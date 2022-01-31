using UnityEngine;
using CodeStage.AdvancedFPSCounter.CountersData;

namespace CodeStage.AdvancedFPSCounter
{
	public class AFPSCounter : MonoBehaviour
	{
		private AFPSCounter()
		{
		}

		public FPSCounterData fpsCounter;
		public MemoryCounterData memoryCounter;
		public DeviceInfoCounterData deviceInfoCounter;
		public KeyCode hotKey;
		public bool keepAlive;
		[SerializeField]
		private OperationMode operationMode;
		[SerializeField]
		private bool forceFrameRate;
		[SerializeField]
		private int forcedFrameRate;
		[SerializeField]
		private Vector2 anchorsOffset;
		[SerializeField]
		private Font labelsFont;
		[SerializeField]
		private int fontSize;
		[SerializeField]
		private float lineSpacing;
		[SerializeField]
		private int countersSpacing;
	}
}
