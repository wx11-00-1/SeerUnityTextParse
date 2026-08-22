using System;

namespace core.config
{
	[Serializable]
	public class MapRoadInfo
	{
		public int gridX;

		public int gridY;

		public bool[] roadInfo;

		public bool[] roadInfo2;

		public byte[] layerInfo;
	}
}
