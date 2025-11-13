using System;

namespace core.config.open_time_limit
{
	// Token: 0x02001F7A RID: 8058
	public class IActivityItem
	{
		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x0600F1C6 RID: 61894 RVA: 0x003F680A File Offset: 0x003F4A0A
		// (set) Token: 0x0600F1C7 RID: 61895 RVA: 0x003F6812 File Offset: 0x003F4A12
		public ITimeLimitItem[] TimeLimit { get; set; }

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x0600F1C8 RID: 61896 RVA: 0x003F681B File Offset: 0x003F4A1B
		// (set) Token: 0x0600F1C9 RID: 61897 RVA: 0x003F6823 File Offset: 0x003F4A23
		public int ID { get; set; }

		// Token: 0x0600F1CA RID: 61898 RVA: 0x003F682C File Offset: 0x003F4A2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.TimeLimit = new ITimeLimitItem[num];
				for (int i = 0; i < num; i++)
				{
					this.TimeLimit[i] = new ITimeLimitItem();
					this.TimeLimit[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
