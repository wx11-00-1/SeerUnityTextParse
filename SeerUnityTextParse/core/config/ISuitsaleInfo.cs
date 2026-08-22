namespace core.config
{
	public class ISuitsaleInfo : IConfigItem
	{
		public int id { get; set; }

		public int itemid { get; set; }

		public int normalprice { get; set; }

		public int specialprice { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			normalprice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			specialprice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
