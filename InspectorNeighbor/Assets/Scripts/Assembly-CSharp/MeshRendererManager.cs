using UnityEngine;
using System.Collections.Generic;

public class MeshRendererManager : MonoBehaviour
{
	public bool m_bUsePVSculling;
	public int m_numEnabledEvaluationsPerUpdate;
	public int m_numDisabledEvaluationsPerUpdate;
	public bool m_bUseMaterialCulling;
	public List<Material> m_disableMaterials;
}
