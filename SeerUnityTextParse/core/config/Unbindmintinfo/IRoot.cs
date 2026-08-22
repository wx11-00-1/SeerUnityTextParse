namespace core.config.Unbindmintinfo
{
	public class IRoot
	{
		public IUnbindActivity UnbindActivity { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				UnbindActivity = new IUnbindActivity();
				UnbindActivity.Parse(bytes, ref byteIndex);
			}
		}
	}
}
