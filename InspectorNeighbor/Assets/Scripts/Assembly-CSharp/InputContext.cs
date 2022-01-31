using System;
using UnityEngine;
using System.Collections.Generic;

[Serializable]
public class InputContext : ScriptableObject
{
	[Serializable]
	public class Control
	{
		public string FriendlyName;
		public string ControlName;
		public bool Mappable;
		public InputContext.KeyState DesiredState;
		public bool Exclusive;
		public bool Raw;
	}

	public enum KeyState
	{
		UP = 0,
		DOWN = 1,
		REPEAT = 2,
		AXIS = 3,
	}

	public List<InputContext.Control> Controls;
	public List<string> Commands;
	public bool AllowsMovement;
	public bool AllowsMouseLook;
	public bool MasksOtherInput;
	public bool PausesGame;
	public bool HidesReticule;
	public bool HidesHUD;
	public bool ShowsCursor;
	public bool AllowsFrob;
	public bool DisallowsButtonKeys;
	public bool DisallowsMenuSubmit;
	public LayerMask FrobLayers;
	public bool OverridesFOV;
	public bool OverridesMouseSensitivity;
	public bool LocksCursor;
	public bool OverridesProperties;
	public string ControllerPresetPath;
	public string CameraPresetPath;
}
