using System;

namespace core.config
{
	// Token: 0x02001E89 RID: 7817
	public class XTeam : XlsConfigBase<XTeam, IXTeamInfo>
	{
		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x0600E8B4 RID: 59572 RVA: 0x003E3A87 File Offset: 0x003E1C87
		public override string fileName
		{
			get
			{
				return "X_Team";
			}
		}

		// Token: 0x0600E8B5 RID: 59573 RVA: 0x003E3A90 File Offset: 0x003E1C90
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IXTeamInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IXTeamInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E8B6 RID: 59574 RVA: 0x003E3AE4 File Offset: 0x003E1CE4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
