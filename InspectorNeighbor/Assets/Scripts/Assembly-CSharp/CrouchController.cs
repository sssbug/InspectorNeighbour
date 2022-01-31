using UnityEngine;
using System.Collections.Generic;

public class CrouchController : MonoBehaviour
{
	public InputContext CrouchedInputContext;
	public InputContext ToggleCrouchedInputContext;
	public List<AudioClip> CrouchingSounds;
	public List<AudioClip> StandupSounds;
}
