namespace core.config
{
	public class IBattleServerShopInfo : IConfigItem
	{
		public int coinid { get; set; }

		public int cointype { get; set; }

		public int count { get; set; }

		public int id { get; set; }

		public int Limitcount { get; set; }

		public int Limittype { get; set; }

		public int price { get; set; }

		public int realid { get; set; }

		public int Subtag { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			Limitcount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Limittype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Subtag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			coinid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cointype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			count = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			realid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
