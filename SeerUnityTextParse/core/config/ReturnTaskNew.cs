using System;

namespace core.config
{
	// Token: 0x02001E01 RID: 7681
	public class ReturnTaskNew : XlsConfigBase<ReturnTaskNew, IReturnTaskNewInfo>
	{
		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x0600E2DC RID: 58076 RVA: 0x003DC553 File Offset: 0x003DA753
		public override string fileName
		{
			get
			{
				return "return_task_new";
			}
		}

		// Token: 0x0600E2DD RID: 58077 RVA: 0x003DC55C File Offset: 0x003DA75C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IReturnTaskNewInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IReturnTaskNewInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E2DE RID: 58078 RVA: 0x003DC5B0 File Offset: 0x003DA7B0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
