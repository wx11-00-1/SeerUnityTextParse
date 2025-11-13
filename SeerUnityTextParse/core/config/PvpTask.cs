using System;

namespace core.config
{
	// Token: 0x02001DE9 RID: 7657
	public class PvpTask : XlsConfigBase<PvpTask, IPvpTaskInfo>
	{
		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x0600E1DC RID: 57820 RVA: 0x003DB00E File Offset: 0x003D920E
		public override string fileName
		{
			get
			{
				return "pvp_task";
			}
		}

		// Token: 0x0600E1DD RID: 57821 RVA: 0x003DB018 File Offset: 0x003D9218
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E1DE RID: 57822 RVA: 0x003DB06C File Offset: 0x003D926C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
