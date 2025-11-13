using System;

namespace core.config
{
	// Token: 0x02001E1D RID: 7709
	public class ShopRecommend : XlsConfigBase<ShopRecommend, IShopRecommendInfo>
	{
		// Token: 0x17001883 RID: 6275
		// (get) Token: 0x0600E41C RID: 58396 RVA: 0x003DDF62 File Offset: 0x003DC162
		public override string fileName
		{
			get
			{
				return "shop_recommend";
			}
		}

		// Token: 0x0600E41D RID: 58397 RVA: 0x003DDF6C File Offset: 0x003DC16C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IShopRecommendInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IShopRecommendInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E41E RID: 58398 RVA: 0x003DDFC0 File Offset: 0x003DC1C0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
