using System;

namespace core.config
{
	// Token: 0x020026C6 RID: 9926
	public class ActivityTimeUpdateConfig : XlsConfigBase<ActivityTimeUpdateConfig, IActivityTimeUpdateConfigInfo>
	{
		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x060138C7 RID: 80071 RVA: 0x00584F74 File Offset: 0x00583174
		public override string fileName
		{
			get
			{
				return "Activity_TimeUpdateConfig";
			}
		}

		// Token: 0x060138C8 RID: 80072 RVA: 0x00584F7C File Offset: 0x0058317C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IActivityTimeUpdateConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IActivityTimeUpdateConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060138C9 RID: 80073 RVA: 0x00584FD0 File Offset: 0x005831D0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
