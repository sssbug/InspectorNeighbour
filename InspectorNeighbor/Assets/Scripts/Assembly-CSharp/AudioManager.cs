using UnityEngine;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{
	public List<ChannelInteraction> Interactions;
	public float OcclusionScalar;
	public LayerMask OcclusionLayers;
	public bool DebugAudio;
}
