namespace core.config.map_config
{
	public class IEntryItem
	{
		public int FromMap { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			FromMap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
