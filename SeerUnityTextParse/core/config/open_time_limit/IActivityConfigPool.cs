using System;

namespace core.config.open_time_limit
{
	// Token: 0x02001F79 RID: 8057
	public class IActivityConfigPool
	{
		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x0600F1C2 RID: 61890 RVA: 0x003F679C File Offset: 0x003F499C
		// (set) Token: 0x0600F1C3 RID: 61891 RVA: 0x003F67A4 File Offset: 0x003F49A4
		public IActivityItem[] Activity { get; set; }

		// Token: 0x0600F1C4 RID: 61892 RVA: 0x003F67B0 File Offset: 0x003F49B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Activity = new IActivityItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Activity[i] = new IActivityItem();
					this.Activity[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
