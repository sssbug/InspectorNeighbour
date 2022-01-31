using UnityEngine;
using System.Collections.Generic;

public class Drawer : MonoBehaviour
{
	public DrawerState StartState;
	public float PartialOpenUnits;
	public string UnlockedText;
	public string LockedText;
	public float LockedStatusDisplayTime;
	public string KeyName;
	public GUIStyle LockTextStyle;
	public float MoveUnits;
	public Vector3 MovementAxis;
	public string OpenFrobTextOverride;
	public string CloseFrobTextOverride;
	public List<AudioClip> OpenSounds;
	public List<AudioClip> CloseSounds;
	public List<AudioClip> StartedMovingSounds;
	public AudioClip LockedSound;
	public AudioClip UnlockSound;
	public float DrawerArrivalThreshold;
}
