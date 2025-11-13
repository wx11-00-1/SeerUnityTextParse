using System;

namespace core.config
{
	// Token: 0x02001D51 RID: 7505
	public class FightTestMonsterConfig : XlsConfigBase<FightTestMonsterConfig, IFightTestMonsterConfigInfo>
	{
		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x0600DB9E RID: 56222 RVA: 0x003D32C4 File Offset: 0x003D14C4
		public override string fileName
		{
			get
			{
				return "fightTestMonsterConfig";
			}
		}

		// Token: 0x0600DB9F RID: 56223 RVA: 0x003D32CC File Offset: 0x003D14CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFightTestMonsterConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFightTestMonsterConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DBA0 RID: 56224 RVA: 0x003D3320 File Offset: 0x003D1520
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
