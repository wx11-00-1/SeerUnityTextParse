namespace core.config.petbook_bisaifu
{
	public class IBranchItem
	{
		public string intro { get; set; }

		public IPlaceItem[] place { get; set; }

		public string title { get; set; }

		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
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
			title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
