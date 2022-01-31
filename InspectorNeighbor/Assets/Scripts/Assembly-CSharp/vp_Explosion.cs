using UnityEngine;
using System.Collections.Generic;

public class vp_Explosion : MonoBehaviour
{
	public float Radius;
	public float Force;
	public float UpForce;
	public float Damage;
	public float CameraShake;
	public string DamageMethodName;
	public AudioClip Sound;
	public float SoundMinPitch;
	public float SoundMaxPitch;
	public List<GameObject> FXPrefabs;
}
