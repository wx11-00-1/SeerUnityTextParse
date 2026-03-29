using System;

namespace core.config
{
	// Token: 0x0200226C RID: 8812
	public class H512thTask : XlsConfigBase<H512thTask, IH512thTaskInfo>
	{
		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06010A5C RID: 68188 RVA: 0x0048D86C File Offset: 0x0048BA6C
		public override string fileName
		{
			get
			{
				return "h5_12th_task";
			}
		}

		// Token: 0x06010A5D RID: 68189 RVA: 0x0048D874 File Offset: 0x0048BA74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IH512thTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IH512thTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06010A5E RID: 68190 RVA: 0x0048D8C8 File Offset: 0x0048BAC8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
