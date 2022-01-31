using UnityEngine;

public class vp_FPSShooter : vp_Component
{
	public GameObject ProjectilePrefab;
	public float ProjectileScale;
	public float ProjectileFiringRate;
	public int ProjectileCount;
	public float ProjectileSpread;
	public Vector3 MotionPositionRecoil;
	public Vector3 MotionRotationRecoil;
	public float MotionPositionReset;
	public float MotionRotationReset;
	public float MotionPositionPause;
	public float MotionRotationPause;
	public float MotionDryFireRecoil;
	public Vector3 MuzzleFlashPosition;
	public Vector3 MuzzleFlashScale;
	public float MuzzleFlashFadeSpeed;
	public GameObject MuzzleFlashPrefab;
	public GameObject ShellPrefab;
	public float ShellScale;
	public Vector3 ShellEjectDirection;
	public Vector3 ShellEjectPosition;
	public float ShellEjectVelocity;
	public float ShellEjectDelay;
	public float ShellEjectSpin;
	public AudioClip SoundFire;
	public AudioClip SoundDryFire;
	public AudioClip SoundReload;
	public Vector2 SoundFirePitch;
	public int AmmoMaxCount;
	public float AmmoReloadTime;
}
