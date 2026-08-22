namespace core.config.petbook_bisaifu
{
	public class IRecMintmark
	{
		public IPlaceItem[] place { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				place = new IPlaceItem[num];
				for (int i = 0; i < num; i++)
				{
					place[i] = new IPlaceItem();
					place[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
