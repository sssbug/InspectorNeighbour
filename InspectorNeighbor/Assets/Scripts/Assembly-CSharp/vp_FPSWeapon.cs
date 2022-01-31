using UnityEngine;

public class vp_FPSWeapon : vp_Component
{
	public float RenderingZoomDamping;
	public float RenderingFieldOfView;
	public Vector2 RenderingClippingPlanes;
	public Vector3 PositionOffset;
	public float PositionSpringStiffness;
	public float PositionSpringDamping;
	public float PositionKneeling;
	public float PositionFallRetract;
	public float PositionPivotSpringStiffness;
	public float PositionPivotSpringDamping;
	public float PositionSpring2Stiffness;
	public float PositionSpring2Damping;
	public Vector3 PositionWalkSlide;
	public Vector3 PositionPivot;
	public float PositionInputVelocityScale;
	public float PositionMaxInputVelocity;
	public Vector3 RotationOffset;
	public float RotationSpringStiffness;
	public float RotationSpringDamping;
	public float RotationSpring2Stiffness;
	public float RotationSpring2Damping;
	public Vector3 RotationLookSway;
	public Vector3 RotationStrafeSway;
	public Vector3 RotationFallSway;
	public float RotationSlopeSway;
	public float RotationInputVelocityScale;
	public float RotationMaxInputVelocity;
	public float ShakeSpeed;
	public Vector3 ShakeAmplitude;
	public Vector4 BobRate;
	public Vector4 BobAmplitude;
	public float BobInputVelocityScale;
	public float BobMaxInputVelocity;
	public AudioClip SoundWield;
	public AudioClip SoundUnWield;
	public Vector3 PositionExitOffset;
	public Vector3 RotationExitOffset;
}
