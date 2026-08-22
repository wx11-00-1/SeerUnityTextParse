namespace core.config
{
	public class ITeamTraderInfo : IConfigItem
	{
		public string item_id { get; set; }

		public string item_name { get; set; }

		public string limit_type { get; set; }

		public string visible { get; set; }

		public int id { get; set; }

		public int limit_num { get; set; }

		public int output { get; set; }

		public int price { get; set; }

		public int sorting { get; set; }

		public int UserInfoId { get; set; }

		public int UserInfoPos { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			UserInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UserInfoPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			item_id = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			item_name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			limit_num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit_type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			output = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			visible = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
