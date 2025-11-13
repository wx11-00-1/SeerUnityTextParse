using System;

namespace core.config
{
	// Token: 0x02001CDD RID: 7389
	public class BraveTask : XlsConfigBase<BraveTask, IBraveTaskInfo>
	{
		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x0600D682 RID: 54914 RVA: 0x003CCFFE File Offset: 0x003CB1FE
		public override string fileName
		{
			get
			{
				return "brave_task";
			}
		}

		// Token: 0x0600D683 RID: 54915 RVA: 0x003CD008 File Offset: 0x003CB208
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBraveTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBraveTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D684 RID: 54916 RVA: 0x003CD05C File Offset: 0x003CB25C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
