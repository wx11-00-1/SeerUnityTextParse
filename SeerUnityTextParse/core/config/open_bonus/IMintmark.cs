namespace core.config.open_bonus
{
	public class IMintmark
	{
		public int ID { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
