using System;

namespace core.config
{
	// Token: 0x02001CB7 RID: 7351
	public class BannerBisaifu : XlsConfigBase<BannerBisaifu, IBannerBisaifuInfo>
	{
		// Token: 0x17001272 RID: 4722
		// (get) Token: 0x0600D52E RID: 54574 RVA: 0x003CB67D File Offset: 0x003C987D
		public override string fileName
		{
			get
			{
				return "banner_bisaifu";
			}
		}

		// Token: 0x0600D52F RID: 54575 RVA: 0x003CB684 File Offset: 0x003C9884
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBannerBisaifuInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBannerBisaifuInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D530 RID: 54576 RVA: 0x003CB6D8 File Offset: 0x003C98D8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
