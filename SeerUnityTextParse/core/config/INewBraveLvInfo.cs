namespace core.config
{
	public class INewBraveLvInfo : IConfigItem
	{
		public string[] stepname { get; set; }

		public string storehouse { get; set; }

		public int id { get; set; }

		public int stepnum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				stepname = new string[num];
				for (int i = 0; i < num; i++)
				{
					stepname[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			stepnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			storehouse = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
