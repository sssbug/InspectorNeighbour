using System;
using System.Collections.Generic;
using UnityEngine;

public class TextJournalItem : JournalItem
{
	[Serializable]
	public class Options
	{
		public bool ResetOnExit;
	}

	public List<string> JournalPages;
	public List<string> JournalImagePaths;
	public List<AudioClip> PageTurnSounds;
	public AudioClip ExitSound;
	public AnimationCurve FadeOutCurve;
	public AnimationCurve FadeInCurve;
	public List<float> FadeOutDurations;
	public List<float> FadeInDurations;
	public AudioDiary DiaryToPlayOnExit;
	public string JournalDisplayDate;
	public int JournalOrder;
	public Options AdvancedOptions;
	public bool AddToInventoryOnExit;
}
