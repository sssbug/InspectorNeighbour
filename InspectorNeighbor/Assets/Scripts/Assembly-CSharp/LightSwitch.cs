using UnityEngine;
using System.Collections.Generic;

public class LightSwitch : MonoBehaviour
{
	public List<Light> TargetLights;
	public List<MeshRenderer> TargetMeshes;
	public bool LightsAreOn;
	public bool ExcludeFromGlobalSetting;
	public string TurnOnFrobTextOverride;
	public string TurnOffFrobTextOverride;
	public Material OnMaterial;
	public Material OffMaterial;
	public AudioClip LightSwitchSound;
	public string OnOffAnimationName;
}
