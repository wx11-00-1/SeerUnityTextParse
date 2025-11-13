using System;

namespace core.config
{
	// Token: 0x02001E33 RID: 7731
	public class SPTtask : XlsConfigBase<SPTtask, ISPTtaskInfo>
	{
		// Token: 0x170018DD RID: 6365
		// (get) Token: 0x0600E4FC RID: 58620 RVA: 0x003DF0B7 File Offset: 0x003DD2B7
		public override string fileName
		{
			get
			{
				return "SPTtask";
			}
		}

		// Token: 0x0600E4FD RID: 58621 RVA: 0x003DF0C0 File Offset: 0x003DD2C0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISPTtaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISPTtaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E4FE RID: 58622 RVA: 0x003DF114 File Offset: 0x003DD314
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
