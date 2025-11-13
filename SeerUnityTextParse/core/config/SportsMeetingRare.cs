using System;

namespace core.config
{
	// Token: 0x02001E2D RID: 7725
	public class SportsMeetingRare : XlsConfigBase<SportsMeetingRare, ISportsMeetingRareInfo>
	{
		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x0600E4D2 RID: 58578 RVA: 0x003DED3B File Offset: 0x003DCF3B
		public override string fileName
		{
			get
			{
				return "sportsMeetingRare";
			}
		}

		// Token: 0x0600E4D3 RID: 58579 RVA: 0x003DED44 File Offset: 0x003DCF44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISportsMeetingRareInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISportsMeetingRareInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E4D4 RID: 58580 RVA: 0x003DED98 File Offset: 0x003DCF98
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
