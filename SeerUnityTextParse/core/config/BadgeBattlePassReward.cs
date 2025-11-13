using System;

namespace core.config
{
	// Token: 0x02001CB1 RID: 7345
	public class BadgeBattlePassReward : XlsConfigBase<BadgeBattlePassReward, IBadgeBattlePassRewardInfo>
	{
		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x0600D4F0 RID: 54512 RVA: 0x003CB1F0 File Offset: 0x003C93F0
		public override string fileName
		{
			get
			{
				return "badgeBattlePass_reward";
			}
		}

		// Token: 0x0600D4F1 RID: 54513 RVA: 0x003CB1F8 File Offset: 0x003C93F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBadgeBattlePassRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBadgeBattlePassRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D4F2 RID: 54514 RVA: 0x003CB24C File Offset: 0x003C944C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
