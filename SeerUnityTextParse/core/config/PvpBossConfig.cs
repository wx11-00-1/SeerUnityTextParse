using System;

namespace core.config
{
	// Token: 0x02002314 RID: 8980
	public class PvpBossConfig : XlsConfigBase<PvpBossConfig, IPvpBossConfigInfo>
	{
		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06011170 RID: 70000 RVA: 0x00496447 File Offset: 0x00494647
		public override string fileName
		{
			get
			{
				return "pvp_BossConfig";
			}
		}

		// Token: 0x06011171 RID: 70001 RVA: 0x00496450 File Offset: 0x00494650
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpBossConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpBossConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011172 RID: 70002 RVA: 0x004964A4 File Offset: 0x004946A4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
