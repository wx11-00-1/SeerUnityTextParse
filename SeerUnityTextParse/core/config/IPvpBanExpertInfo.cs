namespace core.config
{
	public class IPvpBanExpertInfo : IConfigItem
	{
		public string name { get; set; }

		public string reward { get; set; }

		public int id { get; set; }

		public int quantity { get; set; }

		public int seasonopen { get; set; }

		public int subkey_month { get; set; }

		public int subkey_total { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			seasonopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			subkey_month = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			subkey_total = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
