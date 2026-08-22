namespace core.config
{
	public class ICarrygameStageInfo : IConfigItem
	{
		public int id { get; set; }

		public int num1 { get; set; }

		public int num2 { get; set; }

		public int num3 { get; set; }

		public int time { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			num1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
