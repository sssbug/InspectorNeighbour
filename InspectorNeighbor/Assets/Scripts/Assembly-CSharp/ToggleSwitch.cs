using UnityEngine;
using System.Collections.Generic;

public class ToggleSwitch : MonoBehaviour
{
	public List<Component> TargetComponents;
	public bool ToggleOn;
	public string TurnOnFrobTextOverride;
	public string TurnOffFrobTextOverride;
	public AudioClip ToggleSwitchSound;
}
