namespace core.config
{
	public class ILlrestaurantLvlInfo : IConfigItem
	{
		public int condition { get; set; }

		public int id { get; set; }

		public int lvlcondition { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			condition = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			lvlcondition = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
