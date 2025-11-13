using System;

namespace core.config
{
	// Token: 0x02001E77 RID: 7799
	public class TeamTaskInfo : XlsConfigBase<TeamTaskInfo, ITeamTaskInfoInfo>
	{
		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x0600E80C RID: 59404 RVA: 0x003E2CAE File Offset: 0x003E0EAE
		public override string fileName
		{
			get
			{
				return "TeamTaskInfo";
			}
		}

		// Token: 0x0600E80D RID: 59405 RVA: 0x003E2CB8 File Offset: 0x003E0EB8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITeamTaskInfoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITeamTaskInfoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E80E RID: 59406 RVA: 0x003E2D0C File Offset: 0x003E0F0C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
