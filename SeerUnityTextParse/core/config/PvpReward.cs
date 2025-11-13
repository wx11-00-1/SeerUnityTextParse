using System;

namespace core.config
{
	// Token: 0x02001DE1 RID: 7649
	public class PvpReward : XlsConfigBase<PvpReward, IPvpRewardInfo>
	{
		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x0600E172 RID: 57714 RVA: 0x003DA89F File Offset: 0x003D8A9F
		public override string fileName
		{
			get
			{
				return "pvp_reward";
			}
		}

		// Token: 0x0600E173 RID: 57715 RVA: 0x003DA8A8 File Offset: 0x003D8AA8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E174 RID: 57716 RVA: 0x003DA8FC File Offset: 0x003D8AFC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
