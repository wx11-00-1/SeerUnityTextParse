namespace core.config.pet_advance
{
	public class IExMove
	{
		public int ExtraMoves { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			ExtraMoves = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
