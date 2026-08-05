using System;

namespace core.config
{
	// Token: 0x0200290A RID: 10506
	public class PvpCostModeVote : XlsConfigBase<PvpCostModeVote, IPvpCostModeVoteInfo>
	{
		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x06015223 RID: 86563 RVA: 0x005A37DF File Offset: 0x005A19DF
		public override string fileName
		{
			get
			{
				return "pvpCostMode_vote";
			}
		}

		// Token: 0x06015224 RID: 86564 RVA: 0x005A37E8 File Offset: 0x005A19E8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpCostModeVoteInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpCostModeVoteInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06015225 RID: 86565 RVA: 0x005A383C File Offset: 0x005A1A3C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
