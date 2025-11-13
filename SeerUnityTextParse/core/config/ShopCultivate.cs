using System;

namespace core.config
{
	// Token: 0x02001E17 RID: 7703
	public class ShopCultivate : XlsConfigBase<ShopCultivate, IShopCultivateInfo>
	{
		// Token: 0x17001857 RID: 6231
		// (get) Token: 0x0600E3B8 RID: 58296 RVA: 0x003DD745 File Offset: 0x003DB945
		public override string fileName
		{
			get
			{
				return "shop_cultivate";
			}
		}

		// Token: 0x0600E3B9 RID: 58297 RVA: 0x003DD74C File Offset: 0x003DB94C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IShopCultivateInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IShopCultivateInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E3BA RID: 58298 RVA: 0x003DD7A0 File Offset: 0x003DB9A0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
