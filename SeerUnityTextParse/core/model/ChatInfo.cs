using System;

namespace core.model
{
	// Token: 0x02001921 RID: 6433
	public class ChatInfo
	{
		// Token: 0x0600CA71 RID: 51825 RVA: 0x003B000C File Offset: 0x003AE20C
		public ChatInfo(ByteArray data)
		{
			this.m_SenderID = (int)data.ReadUnsignedInt();
			this.m_SenderNicName = data.ReadUTFByte(16);
			this.m_ToID = (int)data.ReadUnsignedInt();
			int length = (int)data.ReadUnsignedInt();
			this.m_Msg = data.ReadUTFByte(length);
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x0600CA72 RID: 51826 RVA: 0x003B0059 File Offset: 0x003AE259
		public int senderID
		{
			get
			{
				return this.m_SenderID;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x0600CA73 RID: 51827 RVA: 0x003B0061 File Offset: 0x003AE261
		public string senderNickName
		{
			get
			{
				return this.m_SenderNicName;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x0600CA74 RID: 51828 RVA: 0x003B0069 File Offset: 0x003AE269
		public int toID
		{
			get
			{
				return this.m_ToID;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x0600CA75 RID: 51829 RVA: 0x003B0071 File Offset: 0x003AE271
		public string msg
		{
			get
			{
				return this.m_Msg;
			}
		}

		// Token: 0x17001026 RID: 4134
		// (get) Token: 0x0600CA76 RID: 51830 RVA: 0x003B0079 File Offset: 0x003AE279
		public int talkID
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x0400DF43 RID: 57155
		private int m_SenderID;

		// Token: 0x0400DF44 RID: 57156
		private string m_SenderNicName;

		// Token: 0x0400DF45 RID: 57157
		private int m_ToID;

		// Token: 0x0400DF46 RID: 57158
		private string m_Msg;

		// Token: 0x0400DF47 RID: 57159
		public bool isRead;
	}
}
