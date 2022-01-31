using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MapFloor
{
	public string FloorName;
	public int FloorNumber;
	public UIPanel FloorPanel;
	public List<MapRoom> Rooms;
	public Vector2 RoomTextureOffset;
}
