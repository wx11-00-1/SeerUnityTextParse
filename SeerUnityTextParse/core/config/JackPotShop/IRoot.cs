namespace core.config.JackPotShop
{
	public class IRoot
	{
		public IBlueChipShops BlueChipShops { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				BlueChipShops = new IBlueChipShops();
				BlueChipShops.Parse(bytes, ref byteIndex);
			}
		}
	}
}
