namespace core.config.resistance
{
	public class IHurtItem
	{
		public int level { get; set; }

		public int need { get; set; }

		public int present { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			need = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			present = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
