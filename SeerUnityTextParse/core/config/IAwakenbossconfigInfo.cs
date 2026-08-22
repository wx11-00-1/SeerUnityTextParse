namespace core.config
{
	public class IAwakenbossconfigInfo : IConfigItem
	{
		public int id { get; set; }

		public int monsterId { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
