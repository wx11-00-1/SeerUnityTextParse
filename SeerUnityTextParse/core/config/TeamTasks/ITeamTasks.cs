using System;

namespace core.config.TeamTasks
{
	// Token: 0x02002488 RID: 9352
	public class ITeamTasks
	{
		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x0601216C RID: 74092 RVA: 0x004B1F86 File Offset: 0x004B0186
		// (set) Token: 0x0601216D RID: 74093 RVA: 0x004B1F8E File Offset: 0x004B018E
		public ITaskItem[] Task { get; set; }

		// Token: 0x0601216E RID: 74094 RVA: 0x004B1F98 File Offset: 0x004B0198
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Task = new ITaskItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Task[i] = new ITaskItem();
					this.Task[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
