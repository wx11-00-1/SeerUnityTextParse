using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F45 RID: 8005
	public class IBattle
	{
		// Token: 0x17001BFF RID: 7167
		// (get) Token: 0x0600F02A RID: 61482 RVA: 0x003F475A File Offset: 0x003F295A
		// (set) Token: 0x0600F02B RID: 61483 RVA: 0x003F4762 File Offset: 0x003F2962
		public ITaskItem[] Task { get; set; }

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x0600F02C RID: 61484 RVA: 0x003F476B File Offset: 0x003F296B
		// (set) Token: 0x0600F02D RID: 61485 RVA: 0x003F4773 File Offset: 0x003F2973
		public int FreeBattleKey { get; set; }

		// Token: 0x0600F02E RID: 61486 RVA: 0x003F477C File Offset: 0x003F297C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.FreeBattleKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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
