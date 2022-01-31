using UnityEngine;
using System.Collections.Generic;

public class Doorr : MonoBehaviour
{
	public enum OneWayDoorType
	{
		LEFT = 0,
		RIGHT = 1,
	}

	public DoorState StartState;
	public float SwingTime;
	public float SwingDegrees;
	public float PartialOpenDegrees;
	public bool InvertedOpenDirection;
	public bool InvertedCloseDirection;
	public bool SwingAway;
	public bool OneWayDoor;
	public OneWayDoorType OneWayDoorState;
	public bool ScriptedOpen;
	public string UnlockedText;
	public string LockedText;
	public float LockedStatusDisplayTime;
	public string KeyName;
	public string OpenFrobTextOverride;
	public string CloseFrobTextOverride;
	public string LockedFrobTextOverride;
	public string UnlockFrobTextOverride;
	public List<AudioClip> OpenSounds;
	public List<AudioClip> CloseSounds;
	public List<AudioClip> StartedSwingingSounds;
	public AudioClip LockedSound;
	public AudioClip UnlockSound;
	public bool DebugSwinging;
	public float StuckTimeThreshold;
}
