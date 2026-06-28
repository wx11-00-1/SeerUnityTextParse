using System;

namespace core.config
{
	// Token: 0x0200255A RID: 9562
	public class AutocardbattlepassReward : XlsConfigBase<AutocardbattlepassReward, IAutocardbattlepassRewardInfo>
	{
		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x0601286B RID: 75883 RVA: 0x005451E6 File Offset: 0x005433E6
		public override string fileName
		{
			get
			{
				return "autocardbattlepass_reward";
			}
		}

		// Token: 0x0601286C RID: 75884 RVA: 0x005451F0 File Offset: 0x005433F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardbattlepassRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardbattlepassRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601286D RID: 75885 RVA: 0x00545244 File Offset: 0x00543444
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
