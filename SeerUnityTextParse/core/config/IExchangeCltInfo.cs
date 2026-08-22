namespace core.config
{
	public class IExchangeCltInfo : IConfigItem
	{
		public string monappend { get; set; }

		public int batch { get; set; }

		public int BitSetId { get; set; }

		public int boundmonster { get; set; }

		public int coinid { get; set; }

		public int cointype { get; set; }

		public int count { get; set; }

		public int id { get; set; }

		public int isjustone { get; set; }

		public int LimitCnt { get; set; }

		public int Limittype { get; set; }

		public int POPID { get; set; }

		public int price { get; set; }

		public int realid { get; set; }

		public int shopid { get; set; }

		public int Subtag { get; set; }

		public int top { get; set; }

		public int type { get; set; }

		public int UserInfoBitPos { get; set; }

		public int UserInfoId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			BitSetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			LimitCnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Limittype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			POPID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			Subtag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UserInfoBitPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			UserInfoId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			batch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			boundmonster = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			coinid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cointype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			count = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			isjustone = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monappend = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			realid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			shopid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			top = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
