using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F49 RID: 8009
	public class IRoot
	{
		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x0600F040 RID: 61504 RVA: 0x003F495D File Offset: 0x003F2B5D
		// (set) Token: 0x0600F041 RID: 61505 RVA: 0x003F4965 File Offset: 0x003F2B65
		public IBackMonsters BackMonsters { get; set; }

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x0600F042 RID: 61506 RVA: 0x003F496E File Offset: 0x003F2B6E
		// (set) Token: 0x0600F043 RID: 61507 RVA: 0x003F4976 File Offset: 0x003F2B76
		public ITaskItem[] Task { get; set; }

		// Token: 0x0600F044 RID: 61508 RVA: 0x003F4980 File Offset: 0x003F2B80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.BackMonsters = new IBackMonsters();
				this.BackMonsters.Parse(bytes, ref byteIndex);
			}
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
