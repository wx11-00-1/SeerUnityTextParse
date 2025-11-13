using System;

namespace core.config
{
	// Token: 0x02001D6B RID: 7531
	public class Jumptarget : XlsConfigBase<Jumptarget, IJumptargetInfo>
	{
		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x0600DC9E RID: 56478 RVA: 0x003D48D7 File Offset: 0x003D2AD7
		public override string fileName
		{
			get
			{
				return "jumptarget";
			}
		}

		// Token: 0x0600DC9F RID: 56479 RVA: 0x003D48E0 File Offset: 0x003D2AE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IJumptargetInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IJumptargetInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DCA0 RID: 56480 RVA: 0x003D4934 File Offset: 0x003D2B34
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
