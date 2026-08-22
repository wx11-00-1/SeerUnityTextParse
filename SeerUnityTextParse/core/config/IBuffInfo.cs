namespace core.config
{
	public class IBuffInfo : IConfigItem
	{
		public string Desc { get; set; }

		public string desc_tag { get; set; }

		public string Tag { get; set; }

		public int[] icon { get; set; }

		public int icontype { get; set; }

		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			Tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			desc_tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				icon = new int[num];
				for (int i = 0; i < num; i++)
				{
					icon[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			icontype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
