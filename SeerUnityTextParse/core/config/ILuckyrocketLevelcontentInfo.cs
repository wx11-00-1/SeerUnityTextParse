namespace core.config
{
	public class ILuckyrocketLevelcontentInfo : IConfigItem
	{
		public string equip { get; set; }

		public string showdescribe { get; set; }

		public string unlock { get; set; }

		public int[] beginindex { get; set; }

		public int[] beginitem { get; set; }

		public int id { get; set; }

		public int level { get; set; }

		public int opentime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				beginindex = new int[num];
				for (int i = 0; i < num; i++)
				{
					beginindex[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				beginitem = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					beginitem[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			equip = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			showdescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			unlock = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
