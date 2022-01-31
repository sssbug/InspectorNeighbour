using UnityEngine;
using System;
using System.Collections.Generic;

public class NGUI_Menu : MonoBehaviour
{
	[Serializable]
	public class NGUI_Menu_Data
	{
		public Camera MainMenuCamera;
		public UIPanel BlackoutPanel;
		public UIPanel TitlePanel;
		public UIPanel UserEngagePanel;
		public UIPanel ControllerDisconnectedPanel;
		public UIPanel MainPanel;
		public UIPanel StartMainPanel;
		public UIPanel OptionsPanel;
		public UIPanel GraphicsOptionsPanel;
		public UIPanel ControlsOptionsPanel;
		public UIPanel AudioOptionsPanel;
		public UIPanel GameplayOptionsPanel;
		public UIPanel BrightnessCalibrationPanel;
		public UIPanel KeyBindingPanel;
		public UIPanel LoadScreen;
		public UIPanel BlackLoadScreen;
		public UIPanel QuitGameConfirmPanel;
		public UIPanel QuitToMenuConfirmPanel;
		public UIPanel ModifiersOptionsPanel;
		public UIPanel LanguageOptionsPanel;
		public UIPanel GraphicsUpdatePanel;
		public UIPanel GamepadOptionsPanel;
		public UIPanel NewGameBrightnessCalibrationPanel;
		public UIPanel SelectControlSchemePanel;
		public UIPanel NewGameConfirmPanel;
		public UITexture GamepadBackground;
		public UITexture WASDBackground;
		public UIButton SwitchToGamepadButton;
		public UILabel WalkLabel;
		public UILabel LookLabel;
	}

	public NGUI_Menu_Data Platform_Standalone_MenuData;
	public NGUI_Menu_Data Platform_PS4_MenuData;
	public NGUI_Menu_Data Platform_XBone_MenuData;
	public InputContext MenuInputContext;
	public InputContext IntroInputContext;
	public List<AudioSource> AudioSourcesToPlayInStartMenu;
	public Material CameraFadeMaterial;
	public float CameraFadeTime;
	public InputContext FadeInputContext;
	public bool StartMenu;
	public bool DebugMenuStateMachine;
}
