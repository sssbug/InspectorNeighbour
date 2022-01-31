using UnityEngine;

public class uScript_MasterComponent : MonoBehaviour
{
	public bool UseAsMaster;
	public uScript_UndoObject undoObjectReference;
	public string[] m_Breakpoints;
	public string CurrentBreakpoint;
	public GameObject[] GameObjects;
	public string[] GameObjectGuids;
	public string[] m_uScriptsToAttach;
	public string[] m_FilesToAddToVC;
}
