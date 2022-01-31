using UnityEngine;
using System.Collections.Generic;

public class PlayerInputController : MonoBehaviour
{
	public InputContext ZoomInputContext;
	public List<AudioClip> RotationSounds;
	public CollisionMaterial DefaultCollisionMaterial;
	public float FootstepInterval;
	public float MapRaycastInterval;
	public LayerMask FootstepLayerMask;
	public LayerMask MapLayerMask;
}
