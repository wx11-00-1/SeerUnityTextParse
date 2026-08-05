using System;

namespace core.config
{
	// Token: 0x020026B4 RID: 9908
	public class AbyssFisheryShop : XlsConfigBase<AbyssFisheryShop, IAbyssFisheryShopInfo>
	{
		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x0601379F RID: 79775 RVA: 0x00583A93 File Offset: 0x00581C93
		public override string fileName
		{
			get
			{
				return "AbyssFisheryShop";
			}
		}

		// Token: 0x060137A0 RID: 79776 RVA: 0x00583A9C File Offset: 0x00581C9C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAbyssFisheryShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAbyssFisheryShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060137A1 RID: 79777 RVA: 0x00583AF0 File Offset: 0x00581CF0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
