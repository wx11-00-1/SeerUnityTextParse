namespace core.config
{
	public class LoginGift : XlsConfigBase<LoginGift, ILoginGiftInfo>
	{
		public override string fileName
		{
			get
			{
				return "LoginGift";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new ILoginGiftInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new ILoginGiftInfo();
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
