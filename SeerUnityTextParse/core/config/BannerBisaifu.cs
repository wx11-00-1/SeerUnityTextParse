namespace core.config
{
	public class BannerBisaifu : XlsConfigBase<BannerBisaifu, IBannerBisaifuInfo>
	{
		public override string fileName
		{
			get
			{
				return "banner_bisaifu";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBannerBisaifuInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBannerBisaifuInfo();
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
