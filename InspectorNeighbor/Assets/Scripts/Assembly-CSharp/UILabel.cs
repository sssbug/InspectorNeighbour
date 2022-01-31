using UnityEngine;

public class UILabel : UIWidget
{
	public enum Effect
	{
		None = 0,
		Shadow = 1,
		Outline = 2,
	}

	[SerializeField]
	private UIFont mFont;
	[SerializeField]
	private string mText;
	[SerializeField]
	private int mMaxLineWidth;
	[SerializeField]
	private bool mEncoding;
	[SerializeField]
	private int mMaxLineCount;
	[SerializeField]
	private bool mPassword;
	[SerializeField]
	private bool mShowLastChar;
	[SerializeField]
	private Effect mEffectStyle;
	[SerializeField]
	private Color mEffectColor;
	[SerializeField]
	private UIFont.SymbolStyle mSymbols;
	[SerializeField]
	private Vector2 mEffectDistance;
	[SerializeField]
	private bool mShrinkToFit;
	public string DefaultFontName;
	[SerializeField]
	private float mLineWidth;
	[SerializeField]
	private bool mMultiline;
}
