namespace core.config
{
	public class ActivityShopConfig : XlsConfigBase<ActivityShopConfig, IActivityShopConfigInfo>
	{
		public override string fileName
		{
			get
			{
				return "Activity_ShopConfig";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IActivityShopConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IActivityShopConfigInfo();
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
