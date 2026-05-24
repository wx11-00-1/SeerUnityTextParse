using System;

namespace core.config
{
	// Token: 0x0200242E RID: 9262
	public class AurumEndgameShop : XlsConfigBase<AurumEndgameShop, IAurumEndgameShopInfo>
	{
		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06011850 RID: 71760 RVA: 0x0050087F File Offset: 0x004FEA7F
		public override string fileName
		{
			get
			{
				return "aurumEndgameShop";
			}
		}

		// Token: 0x06011851 RID: 71761 RVA: 0x00500888 File Offset: 0x004FEA88
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAurumEndgameShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAurumEndgameShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011852 RID: 71762 RVA: 0x005008DC File Offset: 0x004FEADC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
