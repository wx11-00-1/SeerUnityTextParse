namespace core.config
{
	public class IPetSkinRewardtypeInfo : IConfigItem
	{
		public string name { get; set; }

		public string subtypename { get; set; }

		public int id { get; set; }

		public int sort { get; set; }

		public int subtype { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			subtypename = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
