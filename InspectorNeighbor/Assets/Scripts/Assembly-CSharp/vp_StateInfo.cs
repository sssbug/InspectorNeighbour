using System;
using UnityEngine;

[Serializable]
public class vp_StateInfo
{
	public vp_StateInfo(string typeName, string name, string path, TextAsset asset)
	{
	}

	public string TypeName;
	public string Name;
	public TextAsset TextAsset;
	public bool Enabled;
	public bool Allowed;
}
