using UnityEngine;
using System;

public class BootLoader : MonoBehaviour
{
	[Serializable]
	public struct LogoSplash
	{
		public Texture m_logoSplashTexture;
		public Color m_backgroundColor;
		public int m_padX;
		public int m_padY;
		public float m_scaleX;
		public float m_scaleY;
	}

	public bool m_bDisableIntro;
	public bool m_bSkipIntroInDevBuilds;
	public int m_nextLevelIndex;
	public LogoSplash[] m_logoSplashes;
	public float m_nextLevelLoadAsyncDelayRealTime;
	public float m_appSplashFadeOutHoldRealTime;
	public float m_logoSplashFadeInTime;
	public float m_logoSplashFadeInHoldRealTime;
	public float m_logoSplashFadeOutTime;
	public float m_logoSplashFadeOutHoldRealTime;
	public float m_logoSplashFinalFadeOutHoldRealTime;
	public float m_finalFadeInTime;
	public InputContext m_bootLoaderInputContext;
	public float m_bootLoaderInputContextDurationDuringFinalFadeIn;
	public Color m_fadeInColor;
	public Color m_blackColor;
	public Color m_noColor;
}
