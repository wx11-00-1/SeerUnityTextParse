using System;

namespace core.model
{
	// Token: 0x02001935 RID: 6453
	public class FriendsNoticeInfo
	{
		// Token: 0x0600CB70 RID: 52080 RVA: 0x003B1F8C File Offset: 0x003B018C
		public FriendsNoticeInfo(ByteArray data)
		{
			this.m_UserID = (int)data.ReadUnsignedInt();
			this.m_Type = (int)data.ReadUnsignedInt();
			this.m_Data = (int)data.ReadUnsignedInt();
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x0600CB71 RID: 52081 RVA: 0x003B1FB8 File Offset: 0x003B01B8
		public int userID
		{
			get
			{
				return this.m_UserID;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x0600CB72 RID: 52082 RVA: 0x003B1FC0 File Offset: 0x003B01C0
		public int type
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x0600CB73 RID: 52083 RVA: 0x003B1FC8 File Offset: 0x003B01C8
		public int data
		{
			get
			{
				return this.m_Data;
			}
		}

		// Token: 0x0400DFF7 RID: 57335
		private int m_UserID;

		// Token: 0x0400DFF8 RID: 57336
		private int m_Type;

		// Token: 0x0400DFF9 RID: 57337
		private int m_Data;
	}
}
