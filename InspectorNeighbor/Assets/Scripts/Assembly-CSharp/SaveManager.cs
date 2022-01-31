using UnityEngine;
using System.Collections.Generic;

public class SaveManager : MonoBehaviour
{
	public enum SaveMode
	{
		XML = 0,
		Binary = 1,
		OneBigBinaryFile = 2,
	}

	public bool ignoreIntro;
	public InputContext LoadScreenInputContext;
	public string MetaDataSaveFileName;
	public string ObjectsSaveFileName;
	public SaveMode FileSaveMode;
	public List<SaveGame> SaveGames;
	public float AutosaveInterval;
	public string AutosavingText;
	public float AutosaveDisplayTime;
	public float LowestValidSaveVersion;
	public List<int> Saveables;
	public SaveGameMetaData MetaData;
	public bool isLoading;
}
