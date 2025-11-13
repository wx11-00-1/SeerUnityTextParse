using System;

namespace core.config
{
	// Token: 0x02001CB9 RID: 7353
	public class BaseShop : XlsConfigBase<BaseShop, IBaseShopInfo>
	{
		// Token: 0x1700127A RID: 4730
		// (get) Token: 0x0600D542 RID: 54594 RVA: 0x003CB7F5 File Offset: 0x003C99F5
		public override string fileName
		{
			get
			{
				return "baseShop";
			}
		}

		// Token: 0x0600D543 RID: 54595 RVA: 0x003CB7FC File Offset: 0x003C99FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBaseShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBaseShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D544 RID: 54596 RVA: 0x003CB850 File Offset: 0x003C9A50
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
