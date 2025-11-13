using System;

namespace core.config
{
	// Token: 0x02001D53 RID: 7507
	public class FightTestStageConfig : XlsConfigBase<FightTestStageConfig, IFightTestStageConfigInfo>
	{
		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x0600DBC0 RID: 56256 RVA: 0x003D361D File Offset: 0x003D181D
		public override string fileName
		{
			get
			{
				return "fightTestStageConfig";
			}
		}

		// Token: 0x0600DBC1 RID: 56257 RVA: 0x003D3624 File Offset: 0x003D1824
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFightTestStageConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFightTestStageConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DBC2 RID: 56258 RVA: 0x003D3678 File Offset: 0x003D1878
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
