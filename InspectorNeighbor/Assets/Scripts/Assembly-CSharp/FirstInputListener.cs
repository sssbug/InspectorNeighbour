using UnityEngine;
using System.Collections.Generic;

public class FirstInputListener : MonoBehaviour
{
	public float AnalogDetectionDeadZone;
	public List<string> GamepadDeterminingAxes;
	public List<string> GamepadDeterminingKeys;
	public List<string> WASDDeterminingAxes;
	public List<string> WASDDeterminingKeys;
	public float TimeBeforeIdle;
}
