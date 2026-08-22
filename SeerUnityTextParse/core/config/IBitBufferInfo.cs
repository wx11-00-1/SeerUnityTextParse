namespace core.config
{
	public class IBitBufferInfo : IConfigItem
	{
		public int id { get; set; }

		public int index { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			index = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
