using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x02001938 RID: 6456
	public class GpInviteNoticeInfo
	{
		// Token: 0x0600CB86 RID: 52102 RVA: 0x003B20CC File Offset: 0x003B02CC
		public GpInviteNoticeInfo(ByteArray data = null)
		{
			this.m_GroupIDInfo = new GroupIDInfo(data);
			this.m_GroupName = data.ReadUTFByte(16);
			this.m_FromUserID = (int)data.ReadUnsignedInt();
			this.m_FromUserNick = data.ReadUTFByte(16);
			this.m_EvtType = (int)data.ReadUnsignedInt();
			this.m_Data = (int)data.ReadUnsignedInt();
			this.m_LeaderID = (int)data.ReadUnsignedInt();
			this.m_MembList.Clear();
			for (int i = 0; i < 5; i++)
			{
				int num = (int)data.ReadUnsignedInt();
				if (num != 0)
				{
					this.m_MembList.Add(num);
				}
			}
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x0600CB87 RID: 52103 RVA: 0x003B216F File Offset: 0x003B036F
		public GroupIDInfo groupIDInfo
		{
			get
			{
				return this.m_GroupIDInfo;
			}
		}

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x0600CB88 RID: 52104 RVA: 0x003B2177 File Offset: 0x003B0377
		public string groupName
		{
			get
			{
				return this.m_GroupName;
			}
		}

		// Token: 0x170010B4 RID: 4276
		// (get) Token: 0x0600CB89 RID: 52105 RVA: 0x003B217F File Offset: 0x003B037F
		public int fromUserID
		{
			get
			{
				return this.m_FromUserID;
			}
		}

		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x0600CB8A RID: 52106 RVA: 0x003B2187 File Offset: 0x003B0387
		public string fromUserNick
		{
			get
			{
				return this.m_FromUserNick;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x0600CB8B RID: 52107 RVA: 0x003B218F File Offset: 0x003B038F
		public int evtType
		{
			get
			{
				return this.m_EvtType;
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x0600CB8C RID: 52108 RVA: 0x003B2197 File Offset: 0x003B0397
		public int data
		{
			get
			{
				return this.m_Data;
			}
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x0600CB8D RID: 52109 RVA: 0x003B219F File Offset: 0x003B039F
		public int leaderID
		{
			get
			{
				return this.m_LeaderID;
			}
		}

		// Token: 0x170010B9 RID: 4281
		// (get) Token: 0x0600CB8E RID: 52110 RVA: 0x003B21A7 File Offset: 0x003B03A7
		public List<int> membList
		{
			get
			{
				return this.m_MembList;
			}
		}

		// Token: 0x0400E005 RID: 57349
		private GroupIDInfo m_GroupIDInfo;

		// Token: 0x0400E006 RID: 57350
		private string m_GroupName;

		// Token: 0x0400E007 RID: 57351
		private int m_FromUserID;

		// Token: 0x0400E008 RID: 57352
		private string m_FromUserNick;

		// Token: 0x0400E009 RID: 57353
		private int m_EvtType;

		// Token: 0x0400E00A RID: 57354
		private int m_Data;

		// Token: 0x0400E00B RID: 57355
		private int m_LeaderID;

		// Token: 0x0400E00C RID: 57356
		private List<int> m_MembList = new List<int>();
	}
}
