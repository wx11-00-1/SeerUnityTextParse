using System;


namespace core.model
{
	// Token: 0x02001971 RID: 6513
	[Serializable]
	public class ServerInfo
	{
		// Token: 0x0600CC6F RID: 52335 RVA: 0x003B59EC File Offset: 0x003B3BEC
		public ServerInfo(ByteArray data1 = null)
		{
			if (data1 != null)
			{
				this.OnlineID = (int)data1.ReadUnsignedInt();
				this.UserCnt = (int)data1.ReadUnsignedInt();
				this.IP = data1.ReadUTFByte(16);
				ushort port = data1.ReadUnsignedShort();
				this.Port = (int)port;
				this.friends = (int)data1.ReadUnsignedInt();
				//if (this.UserCnt == 0)
				//{
				//	this.UserCnt = Random.Range(0, 5);
				//}
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x0600CC70 RID: 52336 RVA: 0x003B5A57 File Offset: 0x003B3C57
		public int Friends
		{
			get
			{
				return this.friends;
			}
		}

		// Token: 0x0400E2C6 RID: 58054
		public int OnlineID;

		// Token: 0x0400E2C7 RID: 58055
		public int UserCnt;

		// Token: 0x0400E2C8 RID: 58056
		public string IP;

		// Token: 0x0400E2C9 RID: 58057
		public int Port;

		// Token: 0x0400E2CA RID: 58058
		public int friends;

		// Token: 0x0400E2CB RID: 58059
		public string onlineName;
	}
}
