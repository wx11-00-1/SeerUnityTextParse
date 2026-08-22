namespace core.config.email
{
	public class IRoot
	{
		public IElements elements { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				elements = new IElements();
				elements.Parse(bytes, ref byteIndex);
			}
		}
	}
}
