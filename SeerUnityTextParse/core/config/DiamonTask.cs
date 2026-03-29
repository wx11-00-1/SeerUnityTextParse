using System;

namespace core.config
{
	// Token: 0x0200221A RID: 8730
	public class DiamonTask : XlsConfigBase<DiamonTask, IDiamonTaskInfo>
	{
		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x060106B6 RID: 67254 RVA: 0x0048904C File Offset: 0x0048724C
		public override string fileName
		{
			get
			{
				return "diamon_task";
			}
		}

		// Token: 0x060106B7 RID: 67255 RVA: 0x00489054 File Offset: 0x00487254
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDiamonTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDiamonTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060106B8 RID: 67256 RVA: 0x004890A8 File Offset: 0x004872A8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
