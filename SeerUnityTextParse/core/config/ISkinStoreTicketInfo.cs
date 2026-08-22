namespace core.config
{
	public class ISkinStoreTicketInfo : IConfigItem
	{
		public int[] para { get; set; }

		public int id { get; set; }

		public int itemid { get; set; }

		public int productID { get; set; }

		public int tickettype { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				para = new int[num];
				for (int i = 0; i < num; i++)
				{
					para[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			tickettype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
