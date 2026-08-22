namespace core.config
{
	public class IPvpRaceInfo : IConfigItem
	{
		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
