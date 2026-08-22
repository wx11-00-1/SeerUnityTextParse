namespace core.config
{
	public class WishFloatingBottle : XlsConfigBase<WishFloatingBottle, IWishFloatingBottleInfo>
	{
		public override string fileName
		{
			get
			{
				return "WishFloatingBottle";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IWishFloatingBottleInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IWishFloatingBottleInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
