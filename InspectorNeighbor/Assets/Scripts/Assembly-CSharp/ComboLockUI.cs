using UnityEngine;
using System.Collections.Generic;

public class ComboLockUI : MonoBehaviour
{
	public Camera LockCamera;
	public UIPanel LockPanel;
	public List<UIInput> DigitInputs;
	public List<UIButton> IncrementButtons;
	public List<UIButton> DecrementButtons;
	public UIButton OpenButton;
	public InputContext LockInputContext;
	public List<AudioClip> AdjustmentSounds;
	public List<AudioClip> OpenSounds;
}
