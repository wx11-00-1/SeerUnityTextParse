using System;

namespace core.config
{
	// Token: 0x02001E15 RID: 7701
	public class ShopAttire : XlsConfigBase<ShopAttire, IShopAttireInfo>
	{
		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x0600E396 RID: 58262 RVA: 0x003DD418 File Offset: 0x003DB618
		public override string fileName
		{
			get
			{
				return "shop_attire";
			}
		}

		// Token: 0x0600E397 RID: 58263 RVA: 0x003DD420 File Offset: 0x003DB620
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IShopAttireInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IShopAttireInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E398 RID: 58264 RVA: 0x003DD474 File Offset: 0x003DB674
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
