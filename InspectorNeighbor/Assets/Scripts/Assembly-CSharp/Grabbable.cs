using UnityEngine;

public class Grabbable : MonoBehaviour
{
	public float GrabOffset;
	public float GrabUpOffset;
	public float ExamineOffset;
	public float UpExamineOffset;
	public RotateType RotationRestriction;
	public bool UseStartingRotation;
	public Vector3 StartingExamineRotation;
	public float LaunchOffset;
	public float LaunchForceMagnitude;
	public float UpLaunchOffset;
	public float FrobTextResetDelay;
	public float CollisionSoundThreshold;
	public float CollisionSoundCooldown;
	public CollisionMaterial SoundMaterial;
	public bool SleepOnAwake;
	public string LocalizedTextSubtitle;
	public Vector3 TextDisplayThreshold;
}
