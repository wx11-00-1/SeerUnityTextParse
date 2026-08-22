namespace core.config
{
	public class IActivityShopConfigInfo : IConfigItem
	{
		public string commodity { get; set; }

		public string shoptype { get; set; }

		public long timeend { get; set; }

		public int activityid { get; set; }

		public int consumeitemid { get; set; }

		public int exchangeID { get; set; }

		public int id { get; set; }

		public int limit { get; set; }

		public int price { get; set; }

		public int quantity { get; set; }

		public int sort { get; set; }

		public int timelimit { get; set; }

		public int timestart { get; set; }

		public int userinfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			activityid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			exchangeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			shoptype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			timeend = ByteUtil.ReadLong(bytes, ref byteIndex);
			timelimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			timestart = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
