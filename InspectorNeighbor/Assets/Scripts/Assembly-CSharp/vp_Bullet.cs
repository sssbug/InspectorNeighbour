using UnityEngine;
using System.Collections.Generic;

public class vp_Bullet : MonoBehaviour
{
	public float Range;
	public float Force;
	public float Damage;
	public string DamageMethodName;
	public float m_SparkFactor;
	public GameObject m_ImpactPrefab;
	public GameObject m_DustPrefab;
	public GameObject m_SparkPrefab;
	public GameObject m_DebrisPrefab;
	public List<AudioClip> m_ImpactSounds;
	public Vector2 SoundImpactPitch;
}
