namespace core.config
{
	public class ILatestActivityInfo : IConfigItem
	{
		public string[] @goto { get; set; }

		public string showEnd { get; set; }

		public string showStart { get; set; }

		public int id { get; set; }

		public int page { get; set; }

		public int pic { get; set; }

		public int tag { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				@goto = new string[num];
				for (int i = 0; i < num; i++)
				{
					@goto[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			page = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			pic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			showEnd = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			showStart = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
