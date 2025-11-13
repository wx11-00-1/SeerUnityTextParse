using System;

namespace core.config
{
	// Token: 0x02001E2F RID: 7727
	public class SPTreward : XlsConfigBase<SPTreward, ISPTrewardInfo>
	{
		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x0600E4DE RID: 58590 RVA: 0x003DEE2A File Offset: 0x003DD02A
		public override string fileName
		{
			get
			{
				return "SPTreward";
			}
		}

		// Token: 0x0600E4DF RID: 58591 RVA: 0x003DEE34 File Offset: 0x003DD034
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISPTrewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISPTrewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E4E0 RID: 58592 RVA: 0x003DEE88 File Offset: 0x003DD088
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
