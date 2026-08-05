using System;

namespace core.config
{
	// Token: 0x0200290C RID: 10508
	public class PvpCostModeVotePrice : XlsConfigBase<PvpCostModeVotePrice, IPvpCostModeVotePriceInfo>
	{
		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06015241 RID: 86593 RVA: 0x005A39EE File Offset: 0x005A1BEE
		public override string fileName
		{
			get
			{
				return "pvpCostMode_votePrice";
			}
		}

		// Token: 0x06015242 RID: 86594 RVA: 0x005A39F8 File Offset: 0x005A1BF8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpCostModeVotePriceInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpCostModeVotePriceInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06015243 RID: 86595 RVA: 0x005A3A4C File Offset: 0x005A1C4C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
