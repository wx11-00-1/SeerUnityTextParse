namespace core.config
{
	public class IIndianaSpiritInfo : IConfigItem
	{
		public int id { get; set; }

		public int mintmarkID { get; set; }

		public int newSeID { get; set; }

		public int petid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			mintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			newSeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
