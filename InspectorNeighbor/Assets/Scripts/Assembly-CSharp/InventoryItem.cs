using UnityEngine;

public class InventoryItem : ScriptableObject
{
	public Texture2D DisplayIcon;
	public Texture2D DisplayImage;
	public string IconSpriteName;
	public string DisplaySpriteName;
	public string Description;
	public string FriendlyName;
	public bool HideInventoryOnActivate;
}
