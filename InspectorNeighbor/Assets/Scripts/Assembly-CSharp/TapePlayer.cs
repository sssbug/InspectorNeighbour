using UnityEngine;
using System.Collections.Generic;

public class TapePlayer : PlacementTrigger
{
	public Vector3 PlacedTapeOffset;
	public Vector3 PlacedTapeRotation;
	public string TapeInsertText;
	public string TapeRemoveText;
	public List<AudioClip> InsertSounds;
	public List<AudioClip> EjectSounds;
	public float TapeDistanceThreshold;
}
