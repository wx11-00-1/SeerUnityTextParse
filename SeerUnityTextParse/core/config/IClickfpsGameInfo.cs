namespace core.config
{
	public class IClickfpsGameInfo : IConfigItem
	{
		public int id { get; set; }

		public int num { get; set; }

		public int time { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
