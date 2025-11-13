using System;
using System.Collections.Generic;
using System.Linq;

namespace core.model
{
	// Token: 0x02001917 RID: 6423
	public class AllSvrListInfo
	{
		// Token: 0x0600CA17 RID: 51735 RVA: 0x003AE890 File Offset: 0x003ACA90
		public AllSvrListInfo(ByteArray data1)
		{
			data1.position = 0;
			this.m_MaxOnlineID = (int)data1.ReadUnsignedInt();
			int num = (int)data1.ReadUnsignedInt();
			this.m_IsVIP = (num != 0);
			this.m_OnlineTime = (int)data1.ReadUnsignedInt();
			this.m_NetworkPperator = (int)data1.ReadUnsignedInt();
			this.m_OnlineCnt = (int)data1.ReadUnsignedInt();
			this.m_SvrList.Clear();
			this.m_FriendList.Clear();
			for (int i = 0; i < this.m_OnlineCnt; i++)
			{
				ServerInfo item = new ServerInfo(data1);
				this.m_SvrList.Add(item);
			}
			this.m_FriendData = data1;
		}

		// Token: 0x17000FF2 RID: 4082
		// (get) Token: 0x0600CA18 RID: 51736 RVA: 0x003AE942 File Offset: 0x003ACB42
		public int onlineTime
		{
			get
			{
				return this.m_OnlineTime;
			}
		}

		// Token: 0x17000FF3 RID: 4083
		// (get) Token: 0x0600CA19 RID: 51737 RVA: 0x003AE94A File Offset: 0x003ACB4A
		public ByteArray friendData
		{
			get
			{
				return this.m_FriendData;
			}
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x0600CA1A RID: 51738 RVA: 0x003AE952 File Offset: 0x003ACB52
		public List<ServerInfo> svrList
		{
			get
			{
				return this.m_SvrList.ToList<ServerInfo>();
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x0600CA1B RID: 51739 RVA: 0x003AE95F File Offset: 0x003ACB5F
		public int onlineCnt
		{
			get
			{
				return this.m_OnlineCnt;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x0600CA1C RID: 51740 RVA: 0x003AE967 File Offset: 0x003ACB67
		public int maxOnlineID
		{
			get
			{
				return this.m_MaxOnlineID;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x0600CA1D RID: 51741 RVA: 0x003AE96F File Offset: 0x003ACB6F
		public bool isVIP
		{
			get
			{
				return this.m_IsVIP;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x0600CA1E RID: 51742 RVA: 0x003AE977 File Offset: 0x003ACB77
		public int friendCnt
		{
			get
			{
				return this.m_FriendCnt;
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x0600CA1F RID: 51743 RVA: 0x003AE97F File Offset: 0x003ACB7F
		public int networkPperator
		{
			get
			{
				return this.m_NetworkPperator;
			}
		}

		// Token: 0x0400DEBD RID: 57021
		private int m_OnlineTime;

		// Token: 0x0400DEBE RID: 57022
		private int m_NetworkPperator;

		// Token: 0x0400DEBF RID: 57023
		private int m_OnlineCnt;

		// Token: 0x0400DEC0 RID: 57024
		private int m_OnlineID;

		// Token: 0x0400DEC1 RID: 57025
		private int m_UserCnt;

		// Token: 0x0400DEC2 RID: 57026
		private string m_Ip;

		// Token: 0x0400DEC3 RID: 57027
		private int m_Port;

		// Token: 0x0400DEC4 RID: 57028
		private int m_Friends;

		// Token: 0x0400DEC5 RID: 57029
		private int m_MaxOnlineID;

		// Token: 0x0400DEC6 RID: 57030
		private bool m_IsVIP;

		// Token: 0x0400DEC7 RID: 57031
		private int m_FriendCnt;

		// Token: 0x0400DEC8 RID: 57032
		private int m_FriendID;

		// Token: 0x0400DEC9 RID: 57033
		private int m_Stamp;

		// Token: 0x0400DECA RID: 57034
		private List<ServerInfo> m_SvrList = new List<ServerInfo>();

		// Token: 0x0400DECB RID: 57035
		private List<ServerInfo> m_FriendList = new List<ServerInfo>();

		// Token: 0x0400DECC RID: 57036
		private ByteArray m_FriendListByte;

		// Token: 0x0400DECD RID: 57037
		private ByteArray m_FriendData;
	}
}
