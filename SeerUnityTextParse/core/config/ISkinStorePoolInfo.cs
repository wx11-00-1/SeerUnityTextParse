namespace core.config
{
	public class ISkinStorePoolInfo : IConfigItem
	{
		public int consumid { get; set; }

		public int cosNum { get; set; }

		public int disNum { get; set; }

		public int disrate { get; set; }

		public int endtime { get; set; }

		public int freeCosID { get; set; }

		public int freeCosNum { get; set; }

		public int id { get; set; }

		public int poolid { get; set; }

		public int productID1 { get; set; }

		public int productID2 { get; set; }

		public int quality { get; set; }

		public int rate { get; set; }

		public int skinid { get; set; }

		public int starttime { get; set; }

		public int ticket { get; set; }

		public int ticketNum { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			consumid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			cosNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			disNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			disrate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			freeCosID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			freeCosNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			poolid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productID1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productID2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			quality = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			rate = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			skinid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ticket = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			ticketNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
