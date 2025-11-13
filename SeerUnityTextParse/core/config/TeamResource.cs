using System;

namespace core.config
{
	// Token: 0x02001E75 RID: 7797
	public class TeamResource : XlsConfigBase<TeamResource, ITeamResourceInfo>
	{
		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x0600E7FC RID: 59388 RVA: 0x003E2B83 File Offset: 0x003E0D83
		public override string fileName
		{
			get
			{
				return "TeamResource";
			}
		}

		// Token: 0x0600E7FD RID: 59389 RVA: 0x003E2B8C File Offset: 0x003E0D8C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITeamResourceInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITeamResourceInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E7FE RID: 59390 RVA: 0x003E2BE0 File Offset: 0x003E0DE0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
