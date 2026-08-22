namespace core.config.petbook_bisaifu
{
	public class IRoot
	{
		public IHotPet HotPet { get; set; }

		public IHotspot Hotspot { get; set; }

		public IMonsterItem[] Monster { get; set; }

		public IRecMintmark RecMintmark { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				HotPet = new IHotPet();
				HotPet.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Hotspot = new IHotspot();
				Hotspot.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Monster = new IMonsterItem[num];
				for (int i = 0; i < num; i++)
				{
					Monster[i] = new IMonsterItem();
					Monster[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				RecMintmark = new IRecMintmark();
				RecMintmark.Parse(bytes, ref byteIndex);
			}
		}
	}
}
