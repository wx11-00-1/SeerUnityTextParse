using System;

namespace core.model
{
	// Token: 0x0200197F RID: 6527
	internal class TeamChatInfo
	{
		// Token: 0x0600CCCF RID: 52431 RVA: 0x003B6504 File Offset: 0x003B4704
		public TeamChatInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.m_senderID = (int)data.ReadUnsignedInt();
				this.m_nick = data.ReadUTFByte(16);
				this.m_teamID = (int)data.ReadUnsignedInt();
				this.m_msglen = (int)data.ReadUnsignedInt();
				this.m_msg = data.ReadUTFByte(this.m_msglen);
			}
		}

		// Token: 0x17001133 RID: 4403
		// (get) Token: 0x0600CCD0 RID: 52432 RVA: 0x003B655E File Offset: 0x003B475E
		// (set) Token: 0x0600CCD1 RID: 52433 RVA: 0x003B6566 File Offset: 0x003B4766
		public string msg
		{
			get
			{
				return this.m_msg;
			}
			set
			{
				this.m_msg = value;
			}
		}

		// Token: 0x17001134 RID: 4404
		// (get) Token: 0x0600CCD2 RID: 52434 RVA: 0x003B656F File Offset: 0x003B476F
		// (set) Token: 0x0600CCD3 RID: 52435 RVA: 0x003B6577 File Offset: 0x003B4777
		public int senderID
		{
			get
			{
				return this.m_senderID;
			}
			set
			{
				this.m_senderID = value;
			}
		}

		// Token: 0x17001135 RID: 4405
		// (get) Token: 0x0600CCD4 RID: 52436 RVA: 0x003B6580 File Offset: 0x003B4780
		public string nick
		{
			get
			{
				return this.m_nick;
			}
		}

		// Token: 0x17001136 RID: 4406
		// (get) Token: 0x0600CCD5 RID: 52437 RVA: 0x003B6588 File Offset: 0x003B4788
		public int teamID
		{
			get
			{
				return this.m_teamID;
			}
		}

		// Token: 0x17001137 RID: 4407
		// (get) Token: 0x0600CCD6 RID: 52438 RVA: 0x003B6590 File Offset: 0x003B4790
		public int msglen
		{
			get
			{
				return this.m_msglen;
			}
		}

		// Token: 0x0400E337 RID: 58167
		private int m_senderID;

		// Token: 0x0400E338 RID: 58168
		private string m_nick;

		// Token: 0x0400E339 RID: 58169
		private int m_teamID;

		// Token: 0x0400E33A RID: 58170
		private int m_msglen;

		// Token: 0x0400E33B RID: 58171
		private string m_msg;

		// Token: 0x0400E33C RID: 58172
		public bool isRead;
	}
}
