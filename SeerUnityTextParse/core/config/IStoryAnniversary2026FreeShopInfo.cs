namespace core.config
{
	public class IStoryAnniversary2026FreeShopInfo : IConfigItem
	{
		public string desc { get; set; }

		public string price { get; set; }

		public string reward { get; set; }

		public string stat { get; set; }

		public string taskInfo { get; set; }

		public int endtime { get; set; }

		public int id { get; set; }

		public int tasktype { get; set; }

		public int taskValue { get; set; }

		public int type { get; set; }

		public int userbitbuf { get; set; }

		public int userinfo { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			stat = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			taskInfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			taskValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userbitbuf = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
