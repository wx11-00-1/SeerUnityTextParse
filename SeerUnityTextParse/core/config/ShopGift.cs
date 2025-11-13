using System;

namespace core.config
{
	// Token: 0x02001E1B RID: 7707
	public class ShopGift : XlsConfigBase<ShopGift, IShopGiftInfo>
	{
		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x0600E3F6 RID: 58358 RVA: 0x003DDC4A File Offset: 0x003DBE4A
		public override string fileName
		{
			get
			{
				return "shop_gift";
			}
		}

		// Token: 0x0600E3F7 RID: 58359 RVA: 0x003DDC54 File Offset: 0x003DBE54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IShopGiftInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IShopGiftInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E3F8 RID: 58360 RVA: 0x003DDCA8 File Offset: 0x003DBEA8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
