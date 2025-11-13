using System;

namespace core.config
{
	// Token: 0x02001C8F RID: 7311
	public class ActivityTaskConfig : XlsConfigBase<ActivityTaskConfig, IActivityTaskConfigInfo>
	{
		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x0600D382 RID: 54146 RVA: 0x003C96ED File Offset: 0x003C78ED
		public override string fileName
		{
			get
			{
				return "Activity_TaskConfig";
			}
		}

		// Token: 0x0600D383 RID: 54147 RVA: 0x003C96F4 File Offset: 0x003C78F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IActivityTaskConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IActivityTaskConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D384 RID: 54148 RVA: 0x003C9748 File Offset: 0x003C7948
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
