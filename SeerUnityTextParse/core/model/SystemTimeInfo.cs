using System;

namespace core.model
{
	// Token: 0x0200197A RID: 6522
	internal class SystemTimeInfo
	{
		// Token: 0x0600CC8D RID: 52365 RVA: 0x003B5DF0 File Offset: 0x003B3FF0
		public SystemTimeInfo(ByteArray data)
		{
			this.m_time = (int)data.ReadUnsignedInt();
			this.m_date = new DateTime((long)this.m_time * 1000L);
			this.m_date.AddSeconds(28800.0);
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x0600CC8E RID: 52366 RVA: 0x003B5E3D File Offset: 0x003B403D
		public int time
		{
			get
			{
				return this.m_time;
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x0600CC8F RID: 52367 RVA: 0x003B5E45 File Offset: 0x003B4045
		public DateTime date
		{
			get
			{
				return this.m_date;
			}
		}

		// Token: 0x0400E2FA RID: 58106
		private DateTime m_date;

		// Token: 0x0400E2FB RID: 58107
		private int m_time;
	}
}
