using System;

namespace core.config
{
	// Token: 0x02001DB9 RID: 7609
	public class PassShop : XlsConfigBase<PassShop, IPassShopInfo>
	{
		// Token: 0x170016C5 RID: 5829
		// (get) Token: 0x0600DFD8 RID: 57304 RVA: 0x003D8954 File Offset: 0x003D6B54
		public override string fileName
		{
			get
			{
				return "pass_shop";
			}
		}

		// Token: 0x0600DFD9 RID: 57305 RVA: 0x003D895C File Offset: 0x003D6B5C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPassShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPassShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DFDA RID: 57306 RVA: 0x003D89B0 File Offset: 0x003D6BB0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
