using UnityEngine;
using System.Collections.Generic;

public class NGUI_Map : MonoBehaviour
{
	public string MapPathPrefix;
	public string ExploredImagePrefix;
	public string LockedImagePrefix;
	public string OccupiedImagePrefix;
	public List<string> FloorPrefixes;
	public string OccupiedSuffix;
	public string LockedSuffix;
	public List<MapFloor> Floors;
	public UIButton FloorUpButton;
	public UIButton FloorDownButton;
	public UIWidget AnchorPanel;
	public float MapPieceStretchPercentage;
}
