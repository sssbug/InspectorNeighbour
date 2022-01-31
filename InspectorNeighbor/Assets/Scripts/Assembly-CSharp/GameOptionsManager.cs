using UnityEngine;

public class GameOptionsManager : MonoBehaviour
{
	public GameOptions Options;
	public CommentaryOptions CommentaryModeOptions;
	public bool UseFillNeedMethod;
	public float BaseMouseSensitivity;
	public float BaseFOVSpread;
	public int NumberOfQualitySettings;
	public float LowestValidVersion;
	public float LowestValidCommentaryVersion;
	public float OffShadowDistance;
	public float LowShadowDistance;
	public float MediumShadowDistance;
	public float HighShadowDistance;
	public float MaxShadowDistance;
	public int MinimumResolutionWidth;
	public int MinimumResolutionHeight;
	public bool AllowNonNativeAspects;
	public bool IgnoreFirstQuality;
	public bool TempUseAudioDiaries;
	public bool TempUseMap;
	public bool TempLightsOn;
	public bool TempDoorsUnlocked;
	public bool TempCommentaryMode;
	public float TempBrightness;
	public int PendingQualityLevel;
	public string OptionsSaveFileName;
	public string CommentaryOptionsSaveFileName;
	public InputContext WaitForStorageInputContext;
	public float MinBrightness;
	public float MaxBrightness;
	public float MinVolume;
	public float MaxVolume;
	public float MinMouseSensitivity;
	public float MaxMouseSensitivity;
	public float MinGamepadSensitivity;
	public float MaxGamepadSensitivity;
	public float MinFOV;
}
