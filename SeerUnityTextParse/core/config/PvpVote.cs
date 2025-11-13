using System;

namespace core.config
{
	// Token: 0x02001DEB RID: 7659
	public class PvpVote : XlsConfigBase<PvpVote, IPvpVoteInfo>
	{
		// Token: 0x170017A3 RID: 6051
		// (get) Token: 0x0600E1F8 RID: 57848 RVA: 0x003DB201 File Offset: 0x003D9401
		public override string fileName
		{
			get
			{
				return "pvp_vote";
			}
		}

		// Token: 0x0600E1F9 RID: 57849 RVA: 0x003DB208 File Offset: 0x003D9408
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpVoteInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpVoteInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E1FA RID: 57850 RVA: 0x003DB25C File Offset: 0x003D945C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
