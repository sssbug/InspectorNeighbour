using UnityEngine;

public class vp_Spring
{
	public enum TransformType
	{
		Position = 0,
		PositionAdditive = 1,
		Rotation = 2,
		RotationAdditive = 3,
		Scale = 4,
		ScaleAdditive = 5,
	}

	public vp_Spring(Transform transform, vp_Spring.TransformType modifier)
	{
	}

	public TransformType Modifier;
	public Vector3 State;
	public Vector3 RestState;
	public Vector3 Stiffness;
	public Vector3 Damping;
	public float MaxVelocity;
	public float MinVelocity;
	public Vector3 MaxState;
	public Vector3 MinState;
}
