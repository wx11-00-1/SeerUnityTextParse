using System;

namespace core.config
{
	// Token: 0x02002244 RID: 8772
	public class ExpTower : XlsConfigBase<ExpTower, IExpTowerInfo>
	{
		// Token: 0x170019C8 RID: 6600
		// (get) Token: 0x06010898 RID: 67736 RVA: 0x0048B293 File Offset: 0x00489493
		public override string fileName
		{
			get
			{
				return "exp_tower";
			}
		}

		// Token: 0x06010899 RID: 67737 RVA: 0x0048B29C File Offset: 0x0048949C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IExpTowerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IExpTowerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601089A RID: 67738 RVA: 0x0048B2F0 File Offset: 0x004894F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
