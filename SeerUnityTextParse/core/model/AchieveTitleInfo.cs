using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x02001915 RID: 6421
	public class AchieveTitleInfo
	{
		// Token: 0x0600CA13 RID: 51731 RVA: 0x003AE7C4 File Offset: 0x003AC9C4
		public AchieveTitleInfo(ByteArray data)
		{
			this.m_Count = (int)data.ReadUnsignedInt();
			this.m_TitleArr = new List<int>();
			for (int i = 0; i < this.m_Count; i++)
			{
				this.m_TitleArr.Add((int)data.ReadUnsignedInt());
			}
		}

		// Token: 0x17000FF1 RID: 4081
		// (get) Token: 0x0600CA14 RID: 51732 RVA: 0x003AE810 File Offset: 0x003ACA10
		public List<int> titleArr
		{
			get
			{
				return this.m_TitleArr;
			}
		}

		// Token: 0x0400DEB5 RID: 57013
		private int m_Count;

		// Token: 0x0400DEB6 RID: 57014
		private List<int> m_TitleArr;
	}
}
