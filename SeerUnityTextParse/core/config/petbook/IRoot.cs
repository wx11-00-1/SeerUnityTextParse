using System;

namespace core.config.petbook
{
	public class IRoot
	{
		public IHotPet HotPet { get; set; }

		public IHotspot Hotspot { get; set; }

		public IMonsterItem[] Monster { get; set; }

		public IRecMintmark RecMintmark { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			int byteIndex2 = byteIndex;
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				HotPet = new IHotPet();
				HotPet.Parse(bytes, ref byteIndex2);
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				Hotspot = new IHotspot();
				Hotspot.Parse(bytes, ref byteIndex2);
			}
			if (byteIndex2 >= bytes.Length)
			{
				return;
			}
			if (bytes[byteIndex2++] != 0)
			{
				if (byteIndex2 + 4 > bytes.Length)
				{
					return;
				}
				int num = BitConverter.ToInt32(bytes, byteIndex2);
				byteIndex2 += 4;
				if (num > 0)
				{
					Monster = new IMonsterItem[num];
					for (int i = 0; i < num; i++)
					{
						Monster[i] = new IMonsterItem();
						Monster[i].Parse(bytes, ref byteIndex2);
					}
				}
			}
			if (byteIndex2 < bytes.Length)
			{
				if (bytes[byteIndex2++] != 0)
				{
					RecMintmark = new IRecMintmark();
					RecMintmark.Parse(bytes, ref byteIndex2);
				}
				byteIndex = byteIndex2;
			}
		}
	}
}
