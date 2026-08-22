namespace core.config.wenjuan
{
	public class IRoot
	{
		public IDetail detail { get; set; }

		public IWjmain wjmain { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				detail = new IDetail();
				detail.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				wjmain = new IWjmain();
				wjmain.Parse(bytes, ref byteIndex);
			}
		}
	}
}
