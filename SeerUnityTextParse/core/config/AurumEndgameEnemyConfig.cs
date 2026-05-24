using System;

namespace core.config
{
	// Token: 0x02002426 RID: 9254
	public class AurumEndgameEnemyConfig : XlsConfigBase<AurumEndgameEnemyConfig, IAurumEndgameEnemyConfigInfo>
	{
		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x060117FC RID: 71676 RVA: 0x00500292 File Offset: 0x004FE492
		public override string fileName
		{
			get
			{
				return "aurumEndgameEnemyConfig";
			}
		}

		// Token: 0x060117FD RID: 71677 RVA: 0x0050029C File Offset: 0x004FE49C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAurumEndgameEnemyConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAurumEndgameEnemyConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060117FE RID: 71678 RVA: 0x005002F0 File Offset: 0x004FE4F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
