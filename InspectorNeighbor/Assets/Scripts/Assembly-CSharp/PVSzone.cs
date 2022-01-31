using UnityEngine;
using System.Collections.Generic;

public class PVSzone : MonoBehaviour
{
	public enum PVStype
	{
		MeshRenderer = 0,
		Light = 1,
	}

	public PVStype m_PVStype;
	public BoxCollider m_cameraVolume;
	public List<BoxCollider> m_includePVSvolumes;
	public List<BoxCollider> m_excludePVSvolumes;
}
