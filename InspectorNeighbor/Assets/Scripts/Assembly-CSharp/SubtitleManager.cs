using UnityEngine;
using System.Collections.Generic;

public class SubtitleManager : MonoBehaviour
{
	public UICamera SubtitlesCamera;
	public UILabel SubtitlesLabel;
	public List<SubtitledDiary> Diaries;
	public string SubtitlesDirectory;
	public float SubtitleEndOverride;
}
