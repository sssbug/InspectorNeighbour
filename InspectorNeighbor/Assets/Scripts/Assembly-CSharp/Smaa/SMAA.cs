using UnityEngine;

namespace Smaa
{
	public class SMAA : MonoBehaviour
	{
		public HDRMode Hdr;
		public DebugPass DebugPass;
		public QualityPreset Quality;
		public EdgeDetectionMethod DetectionMethod;
		public bool UsePredication;
		public Preset CustomPreset;
		public PredicationPreset CustomPredicationPreset;
		public Shader Shader;
		public Texture2D AreaTex;
		public Texture2D SearchTex;
	}
}
