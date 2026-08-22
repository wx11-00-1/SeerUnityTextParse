namespace core.config.vip_pet_shop
{
	public class IRoot
	{
		public IPetItem[] Pet { get; set; }

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				Pet = new IPetItem[num];
				for (int i = 0; i < num; i++)
				{
					Pet[i] = new IPetItem();
					Pet[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
