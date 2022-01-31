using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CollisionSoundSet
{
	public string Name;
	public List<CollisionMaterial> Materials;
	public List<AudioClip> Clips;
}
