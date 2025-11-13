using System;

namespace core.config
{
	// Token: 0x02001DFF RID: 7679
	public class ReturnTask : XlsConfigBase<ReturnTask, IReturnTaskInfo>
	{
		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x0600E2D0 RID: 58064 RVA: 0x003DC43D File Offset: 0x003DA63D
		public override string fileName
		{
			get
			{
				return "return_task";
			}
		}

		// Token: 0x0600E2D1 RID: 58065 RVA: 0x003DC444 File Offset: 0x003DA644
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IReturnTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IReturnTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E2D2 RID: 58066 RVA: 0x003DC498 File Offset: 0x003DA698
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
