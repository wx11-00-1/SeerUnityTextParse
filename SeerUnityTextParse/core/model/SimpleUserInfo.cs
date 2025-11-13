using System;
using core.manager;
//using Libra.Util;

namespace core.model
{
	// Token: 0x02001973 RID: 6515
	public class SimpleUserInfo
	{
		// Token: 0x0600CC72 RID: 52338 RVA: 0x003B5AD7 File Offset: 0x003B3CD7
		public SimpleUserInfo(ByteArray data)
		{
			if (data != null)
			{
				this.uid = (int)data.ReadUnsignedInt();
				this.nick = data.ReadUTFByte(16);
				this.logoutTime = (int)data.ReadUnsignedInt();
			}
		}

		// Token: 0x0600CC73 RID: 52339 RVA: 0x003B5B08 File Offset: 0x003B3D08
		public string getStatus()
		{
			string result = "在线";
			if (this.logoutTime > 0)
			{
				//result = TimeFormatUtil.GetLastOnlineTime(SystemTimerManager.time - (long)this.logoutTime);
			}
			return result;
		}

		// Token: 0x0400E2D4 RID: 58068
		public int uid;

		// Token: 0x0400E2D5 RID: 58069
		public string nick;

		// Token: 0x0400E2D6 RID: 58070
		public int logoutTime;
	}
}
