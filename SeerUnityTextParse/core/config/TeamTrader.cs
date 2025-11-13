using System;

namespace core.config
{
	// Token: 0x02001E79 RID: 7801
	public class TeamTrader : XlsConfigBase<TeamTrader, ITeamTraderInfo>
	{
		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x0600E824 RID: 59428 RVA: 0x003E2EE9 File Offset: 0x003E10E9
		public override string fileName
		{
			get
			{
				return "teamTrader";
			}
		}

		// Token: 0x0600E825 RID: 59429 RVA: 0x003E2EF0 File Offset: 0x003E10F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITeamTraderInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITeamTraderInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E826 RID: 59430 RVA: 0x003E2F44 File Offset: 0x003E1144
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
