namespace core.config
{
	public class IBraveTowerReverseDefenseTyperelationInfo : IConfigItem
	{
		public int id { get; set; }

		public int typeid { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			typeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
