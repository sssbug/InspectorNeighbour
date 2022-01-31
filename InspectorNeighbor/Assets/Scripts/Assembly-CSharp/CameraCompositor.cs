using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Rendering;

public class CameraCompositor : MonoBehaviour
{
	public List<Camera> m_nonMainSceneCameras;
	public List<Camera> m_uiCameras;
	public GameObject m_mainScenePostFXcontainer;
	public GameObject m_nonMainScenePostFXcontainer;
	public OpaqueSortMode m_sceneCamerasOpaqueSortMode;
	public OpaqueSortMode m_uiCamerasOpaqueSortMode;
	public float m_nonMainSceneLightsRadius;
}
