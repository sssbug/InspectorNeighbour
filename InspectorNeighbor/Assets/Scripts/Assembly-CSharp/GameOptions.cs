using System;

[Serializable]
public class GameOptions
{
	public float FOV;
	public float Volume;
	public float MouseSensitivityScalar;
	public float Brightness;
	public bool InvertY;
	public bool Fullscreen;
	public UResolution Res;
	public bool Vsync;
	public float ShadowDrawDistance;
	public int Aniso;
	public bool FXAA;
	public int QualityLevel;
	public float Version;
	public ControlScheme SelectedControlScheme;
	public bool ToggleCrouch;
	public bool SSAO;
	public bool InvertGamepadY;
	public float GamepadLookSensitivityScalar;
	public bool MouseSmoothing;
	public bool UseAudioDiaries;
	public bool ShowTrainingMessages;
	public bool UseMap;
	public bool Headbob;
	public bool Subtitles;
	public float VoiceVolume;
	public float EffectsVolume;
	public float MusicVolume;
	public bool DoorsUnlocked;
	public bool LightsOn;
	public bool Bloom;
	public bool MotionBlur;
	public bool DisableFrobText;
	public bool DisableFrobHighlight;
	public bool DisableReticule;
	public bool AimAssistActive;
	public string Language;
	public bool ShowOverlayText;
	public bool SwapGamepadSticks;
	public float AspectRatio;
	public bool MouseAcceleration;
}
