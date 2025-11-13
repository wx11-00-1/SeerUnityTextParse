using System;

namespace core.config
{
	// Token: 0x02001D4F RID: 7503
	public class FightTestBossConfig : XlsConfigBase<FightTestBossConfig, IFightTestBossConfigInfo>
	{
		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x0600DB8A RID: 56202 RVA: 0x003D30A3 File Offset: 0x003D12A3
		public override string fileName
		{
			get
			{
				return "fightTestBossConfig";
			}
		}

		// Token: 0x0600DB8B RID: 56203 RVA: 0x003D30AC File Offset: 0x003D12AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFightTestBossConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFightTestBossConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DB8C RID: 56204 RVA: 0x003D3100 File Offset: 0x003D1300
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
