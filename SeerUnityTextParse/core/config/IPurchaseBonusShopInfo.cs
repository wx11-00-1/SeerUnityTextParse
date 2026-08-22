namespace core.config
{
	public class IPurchaseBonusShopInfo : IConfigItem
	{
		public int[] commodity { get; set; }

		public int consumeitemid { get; set; }

		public int id { get; set; }

		public int limit { get; set; }

		public int price { get; set; }

		public int quantity { get; set; }

		public int shoptype { get; set; }

		public int stat { get; set; }

		public int userinfo { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				commodity = new int[num];
				for (int i = 0; i < num; i++)
				{
					commodity[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			shoptype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			stat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
