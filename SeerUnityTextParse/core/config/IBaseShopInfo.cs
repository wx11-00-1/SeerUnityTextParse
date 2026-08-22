namespace core.config
{
	public class IBaseShopInfo : IConfigItem
	{
		public string cost { get; set; }

		public string name { get; set; }

		public int id { get; set; }

		public int max { get; set; }

		public int num { get; set; }

		public int type { get; set; }

		public int vipOnly { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			cost = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			vipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
