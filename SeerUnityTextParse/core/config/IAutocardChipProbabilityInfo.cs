namespace core.config
{
	public class IAutocardChipProbabilityInfo : IConfigItem
	{
		public int id { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
