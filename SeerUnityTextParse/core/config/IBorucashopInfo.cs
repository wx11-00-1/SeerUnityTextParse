namespace core.config
{
	public class IBorucashopInfo : IConfigItem
	{
		public int endtime { get; set; }

		public int id { get; set; }

		public int itemid { get; set; }

		public int price { get; set; }

		public int quantity { get; set; }

		public int quota { get; set; }

		public int starttime { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quota = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
