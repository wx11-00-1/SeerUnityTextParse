using System;

namespace core.config
{
	// Token: 0x02002156 RID: 8534
	public class BackFlowTask : XlsConfigBase<BackFlowTask, IBackFlowTaskInfo>
	{
		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x0600FDE8 RID: 65000 RVA: 0x0047E965 File Offset: 0x0047CB65
		public override string fileName
		{
			get
			{
				return "BackFlowTask";
			}
		}

		// Token: 0x0600FDE9 RID: 65001 RVA: 0x0047E96C File Offset: 0x0047CB6C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBackFlowTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBackFlowTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FDEA RID: 65002 RVA: 0x0047E9C0 File Offset: 0x0047CBC0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
