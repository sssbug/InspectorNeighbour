using UnityEngine;

public class DebugManager : MonoBehaviour
{
	public float FPSUpdateInterval;
	public float FPSAverageWeightRatio;
	public float LowFPSThreshold;
	public float MedFPSThreshold;
	public bool OutputJoystickButtonPresses;
	public UILabel FPSLabel;
	public UIPanel DebugMenuPanel;
	public UIPanel HUDTextPanel;
	public UIPanel MainHUDPanel;
}
