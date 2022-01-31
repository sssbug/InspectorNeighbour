using UnityEngine;
using System.Collections.Generic;

public class InputHandler : MonoBehaviour
{
	public List<InputContext> MappableContexts;
	public InputContext DefaultInputContext;
	public string KeyBindingSaveFileName;
	public string DefaultKeyBindingSaveFileName;
	public string AlternateControlSaveFileName;
	public string AlternateReboundSaveFileName;
	public string GamepadDefaultSaveFileName;
	public string GamepadReboundSaveFileName;
	public float AxisThreshold;
	public List<AnalogKeyBinding> AnalogBinds;
	public float LowestValidBindingSaveVersion;
	public ControlMapSaveInfo SaveInfo;
	public string[] MappableSpecialKeys;
	public List<KeyFriendlyName> FriendlyNames;
	public List<KeyFriendlyName> FriendlyNames_PS4;
	public List<KeyFriendlyName> FriendlyNames_XBone;
	public List<KeyMapping> DefaultWASDKeyMappings;
	public List<KeyMapping> DefaultExplorerKeyMappings;
	public List<KeyMapping> DefaultGamepadKeyMappings;
	public float FullSpeedTimeScale;
	public DebugLevel DebugInput;
	public string GamepadLeftXAxis;
	public string GamepadRightXAxis;
	public string GamepadLeftYAxis;
	public string GamepadRightYAxis;
	public List<UIFont> FontsToRefresh;
	public string[] SendMessageForCommands;
}
