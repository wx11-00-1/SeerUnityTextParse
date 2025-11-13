using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x0200196D RID: 6509
	internal class RangeSvrInfo
	{
		// Token: 0x0600CC68 RID: 52328 RVA: 0x003B5930 File Offset: 0x003B3B30
		public RangeSvrInfo(ByteArray data1)
		{
			data1.position = 0;
			this.m_onlineCnt = (int)data1.ReadUnsignedInt();
			this.m_serverList.Clear();
			for (int i = 0; i < this.m_onlineCnt; i++)
			{
				ServerInfo item = new ServerInfo(data1);
				this.m_serverList.Add(item);
			}
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x0600CC69 RID: 52329 RVA: 0x003B5990 File Offset: 0x003B3B90
		public int onlineCnt
		{
			get
			{
				return this.m_onlineCnt;
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x0600CC6A RID: 52330 RVA: 0x003B5998 File Offset: 0x003B3B98
		public List<ServerInfo> svrList
		{
			get
			{
				return this.m_serverList;
			}
		}

		// Token: 0x0400E2BA RID: 58042
		private int m_onlineCnt;

		// Token: 0x0400E2BB RID: 58043
		private List<ServerInfo> m_serverList = new List<ServerInfo>();
	}
}
