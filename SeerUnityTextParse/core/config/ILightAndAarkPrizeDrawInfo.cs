namespace core.config
{
	public class ILightAndAarkPrizeDrawInfo : IConfigItem
	{
		public int id { get; set; }

		public int monId { get; set; }

		public int productID { get; set; }

		public int type { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
