namespace core.config
{
	public class ISkinMonInfo : IConfigItem
	{
		public int[] oncereward { get; set; }

		public int[] taskreward { get; set; }

		public int endtime { get; set; }

		public int id { get; set; }

		public int itemID { get; set; }

		public int onsaleprice { get; set; }

		public int price { get; set; }

		public int productID { get; set; }

		public int rewardtime { get; set; }

		public int starttime { get; set; }

		public int userinfo1 { get; set; }

		public int userinfo2 { get; set; }

		public int userinfo3 { get; set; }

		public int value { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				oncereward = new int[num];
				for (int i = 0; i < num; i++)
				{
					oncereward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			onsaleprice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rewardtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				taskreward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					taskreward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			userinfo1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
