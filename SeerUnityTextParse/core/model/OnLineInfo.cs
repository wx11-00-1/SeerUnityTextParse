using System;

namespace core.model
{
	// Token: 0x0200194C RID: 6476
	public class OnLineInfo
	{
		// Token: 0x0600CBD9 RID: 52185 RVA: 0x003B2E52 File Offset: 0x003B1052
		public OnLineInfo(ByteArray data = null)
		{
			this.m_userID = (int)data.ReadUnsignedInt();
			this.m_serverID = (int)data.ReadUnsignedInt();
			this.m_mapType = (int)data.ReadUnsignedInt();
			this.m_mapID = (int)data.ReadUnsignedInt();
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x0600CBDA RID: 52186 RVA: 0x003B2E8A File Offset: 0x003B108A
		public int userID
		{
			get
			{
				return this.m_userID;
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x0600CBDB RID: 52187 RVA: 0x003B2E92 File Offset: 0x003B1092
		public int serverID
		{
			get
			{
				return this.m_serverID;
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x0600CBDC RID: 52188 RVA: 0x003B2E9A File Offset: 0x003B109A
		public int mapType
		{
			get
			{
				return this.m_mapType;
			}
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x0600CBDD RID: 52189 RVA: 0x003B2EA2 File Offset: 0x003B10A2
		public int mapID
		{
			get
			{
				return this.m_mapID;
			}
		}

		// Token: 0x0400E15A RID: 57690
		private int m_userID;

		// Token: 0x0400E15B RID: 57691
		private int m_serverID;

		// Token: 0x0400E15C RID: 57692
		private int m_mapType;

		// Token: 0x0400E15D RID: 57693
		private int m_mapID;
	}
}
