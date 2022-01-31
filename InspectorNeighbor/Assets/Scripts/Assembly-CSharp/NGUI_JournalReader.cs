using UnityEngine;

public class NGUI_JournalReader : MonoBehaviour
{
	public UIPanel JournalPanel;
	public Camera JournalCamera;
	public UILabel TextFieldLabel;
	public UITexture PageTexture;
	public UIImageButton ForwardButton;
	public UIImageButton BackButton;
	public UIImageButton DisabledBackButton;
	public UIImageButton DisabledForwardButton;
	public UILabel PageLabel;
	public UIButton TextButton;
	public UILabel TextControllerLabel;
	public UIImageButton ExitButton;
	public float TextDisplayImageAlpha;
	public string JournalsDirectory;
	public UIPanel TextPanel;
	public Shader ImageShader;
	public InputContext JournalReadingInputContext;
	public string PageImageDirectory;
	public float PageTurnThreshold;
}
