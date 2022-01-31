using UnityEngine;

public class vp_DamageHandler : MonoBehaviour
{
	public float Health;
	public GameObject DeathEffect;
	public float MinDeathDelay;
	public float MaxDeathDelay;
	public bool Respawns;
	public float MinRespawnTime;
	public float MaxRespawnTime;
	public float RespawnCheckRadius;
	public AudioClip RespawnSound;
}
