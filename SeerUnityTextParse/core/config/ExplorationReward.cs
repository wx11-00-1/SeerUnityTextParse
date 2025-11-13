using System;

namespace core.config
{
	// Token: 0x02001D45 RID: 7493
	public class ExplorationReward : XlsConfigBase<ExplorationReward, IExplorationRewardInfo>
	{
		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x0600DB20 RID: 56096 RVA: 0x003D284C File Offset: 0x003D0A4C
		public override string fileName
		{
			get
			{
				return "ExplorationReward";
			}
		}

		// Token: 0x0600DB21 RID: 56097 RVA: 0x003D2854 File Offset: 0x003D0A54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IExplorationRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IExplorationRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DB22 RID: 56098 RVA: 0x003D28A8 File Offset: 0x003D0AA8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
