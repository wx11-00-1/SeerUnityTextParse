using System;

namespace core.config
{
	// Token: 0x02001DED RID: 7661
	public class PvpVoteTemp : XlsConfigBase<PvpVoteTemp, IPvpVoteTempInfo>
	{
		// Token: 0x170017AF RID: 6063
		// (get) Token: 0x0600E214 RID: 57876 RVA: 0x003DB3F1 File Offset: 0x003D95F1
		public override string fileName
		{
			get
			{
				return "pvp_vote_temp";
			}
		}

		// Token: 0x0600E215 RID: 57877 RVA: 0x003DB3F8 File Offset: 0x003D95F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpVoteTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpVoteTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E216 RID: 57878 RVA: 0x003DB44C File Offset: 0x003D964C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
