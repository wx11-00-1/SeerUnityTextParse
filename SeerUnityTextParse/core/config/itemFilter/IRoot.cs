namespace core.config.itemFilter
{
	public class IRoot
	{
		public IBlood Blood { get; set; }

		public ICatch Catch { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Blood = new IBlood();
				Blood.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Catch = new ICatch();
				Catch.Parse(bytes, ref byteIndex);
			}
		}
	}
}
