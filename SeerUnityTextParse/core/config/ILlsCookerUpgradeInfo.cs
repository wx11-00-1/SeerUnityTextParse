namespace core.config
{
	public class ILlsCookerUpgradeInfo : IConfigItem
	{
		public int id { get; set; }

		public int isupgrade { get; set; }

		public int price1 { get; set; }

		public int price2 { get; set; }

		public int price3 { get; set; }

		public int time1 { get; set; }

		public int time2 { get; set; }

		public int time3 { get; set; }

		public int type { get; set; }

		public int unlock { get; set; }

		public int upgrade1 { get; set; }

		public int upgrade2 { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isupgrade = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			upgrade1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			upgrade2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
