using System;

public class PlatformManager_PS4 : PlatformManager
{
	[Serializable]
	public struct TrophyPackIndices
	{
		public int m_idxGoneHome;
		public int m_idxLettersToKatie;
		public int m_idxMeowMeowMeow;
		public int m_idxHomeRunner;
		public int m_idxSpeedReader;
		public int m_idxBehindTheScenes;
		public int m_idxNestingInstinct;
		public int m_idxWetBandit;
		public int m_idxIntuitive;
		public int m_idxThisOldHouse;
	}

	public TrophyPackIndices m_trophyPackIndices;
}
