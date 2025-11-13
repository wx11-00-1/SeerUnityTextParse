using System;

namespace core.config
{
	// Token: 0x02001CBB RID: 7355
	public class BattlepassReward : XlsConfigBase<BattlepassReward, IBattlepassRewardInfo>
	{
		// Token: 0x17001282 RID: 4738
		// (get) Token: 0x0600D556 RID: 54614 RVA: 0x003CB966 File Offset: 0x003C9B66
		public override string fileName
		{
			get
			{
				return "battlepass_reward";
			}
		}

		// Token: 0x0600D557 RID: 54615 RVA: 0x003CB970 File Offset: 0x003C9B70
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBattlepassRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBattlepassRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D558 RID: 54616 RVA: 0x003CB9C4 File Offset: 0x003C9BC4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
