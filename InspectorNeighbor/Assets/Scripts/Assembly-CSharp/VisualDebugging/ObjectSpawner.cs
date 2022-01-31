using UnityEngine;

namespace VisualDebugging
{
	public class ObjectSpawner : MonoBehaviour
	{
		public enum CubeNum
		{
			Max = 1,
			High = 2,
			Medium = 3,
			low = 4,
		}

		public CubeNum totalSpawn;
		public GameObject objectPF;
	}
}
