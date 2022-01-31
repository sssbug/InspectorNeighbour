using UnityEngine;

public class vp_FPSController : vp_Component
{
	public float MotorAcceleration;
	public float MotorDamping;
	public float MotorJumpForce;
	public float MotorAirSpeed;
	public float MotorSlopeSpeedUp;
	public float MotorSlopeSpeedDown;
	public float AnalogXAxisMove;
	public float AnalogYAxisMove;
	public AnimationCurve AnalogMoveAccelCurve;
	public float PhysicsForceDamping;
	public float PhysicsPushForce;
	public float PhysicsGravityModifier;
	public float PhysicsWallBounce;
}
