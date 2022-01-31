using UnityEngine;
using UnityEngine.UI;

namespace CodeStage.AdvancedFPSCounter.Labels
{
	internal class DrawableLabel
	{
		public DrawableLabel(LabelAnchor anchor, Vector2 pixelOffset, Font font, int fontSize, float lineSpacing)
		{
		}

		public LabelAnchor anchor;
		public Text guiText;
		public bool dirty;
	}
}
