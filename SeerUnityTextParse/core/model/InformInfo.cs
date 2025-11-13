using System;

namespace core.model
{
	// Token: 0x0200193E RID: 6462
	internal class InformInfo
	{
		// Token: 0x0600CB9E RID: 52126 RVA: 0x003B2280 File Offset: 0x003B0480
		public InformInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.m_type = (int)data.ReadUnsignedInt();
				this.m_userID = (int)data.ReadUnsignedInt();
				this.m_nick = data.ReadUTFByte(16);
				this.m_accept = (int)data.ReadUnsignedInt();
				this.m_serverID = (int)data.ReadUnsignedInt();
				this.m_mapType = (int)data.ReadUnsignedInt();
				this.m_mapID = (int)data.ReadUnsignedInt();
				this.m_mapName = data.ReadUTFByte(64);
			}
		}

		// Token: 0x170010BE RID: 4286
		// (get) Token: 0x0600CB9F RID: 52127 RVA: 0x003B22FA File Offset: 0x003B04FA
		// (set) Token: 0x0600CBA0 RID: 52128 RVA: 0x003B2302 File Offset: 0x003B0502
		public int type
		{
			get
			{
				return this.m_type;
			}
			set
			{
				this.m_type = value;
			}
		}

		// Token: 0x170010BF RID: 4287
		// (get) Token: 0x0600CBA1 RID: 52129 RVA: 0x003B230B File Offset: 0x003B050B
		public int userID
		{
			get
			{
				return this.m_userID;
			}
		}

		// Token: 0x170010C0 RID: 4288
		// (get) Token: 0x0600CBA2 RID: 52130 RVA: 0x003B2313 File Offset: 0x003B0513
		public string nick
		{
			get
			{
				return this.m_nick;
			}
		}

		// Token: 0x170010C1 RID: 4289
		// (get) Token: 0x0600CBA3 RID: 52131 RVA: 0x003B231B File Offset: 0x003B051B
		public int accept
		{
			get
			{
				return this.m_accept;
			}
		}

		// Token: 0x170010C2 RID: 4290
		// (get) Token: 0x0600CBA4 RID: 52132 RVA: 0x003B2323 File Offset: 0x003B0523
		public int serverID
		{
			get
			{
				return this.m_serverID;
			}
		}

		// Token: 0x170010C3 RID: 4291
		// (get) Token: 0x0600CBA5 RID: 52133 RVA: 0x003B232B File Offset: 0x003B052B
		public int mapID
		{
			get
			{
				return this.m_mapID;
			}
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x0600CBA6 RID: 52134 RVA: 0x003B2333 File Offset: 0x003B0533
		public int mapType
		{
			get
			{
				return this.m_mapType;
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x0600CBA7 RID: 52135 RVA: 0x003B233B File Offset: 0x003B053B
		public string mapName
		{
			get
			{
				return this.m_mapName;
			}
		}

		// Token: 0x0400E0DE RID: 57566
		private int m_type;

		// Token: 0x0400E0DF RID: 57567
		private int m_userID;

		// Token: 0x0400E0E0 RID: 57568
		private string m_nick;

		// Token: 0x0400E0E1 RID: 57569
		private int m_accept;

		// Token: 0x0400E0E2 RID: 57570
		private int m_serverID;

		// Token: 0x0400E0E3 RID: 57571
		private int m_mapType;

		// Token: 0x0400E0E4 RID: 57572
		private int m_mapID;

		// Token: 0x0400E0E5 RID: 57573
		private string m_mapName;

		// Token: 0x0400E0E6 RID: 57574
		public object exInfo;
	}
}
