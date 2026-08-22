namespace core.config.skin_shop
{
	public class IRoot
	{
		public ISkins Skins { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				Skins = new ISkins();
				Skins.Parse(bytes, ref byteIndex);
			}
		}
	}
}
