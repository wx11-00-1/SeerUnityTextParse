using System;

namespace core.model
{
	// Token: 0x02001939 RID: 6457
	public class GroupManager
	{
		// Token: 0x170010BA RID: 4282
		// (get) Token: 0x0600CB90 RID: 52112 RVA: 0x003B21B9 File Offset: 0x003B03B9
		// (set) Token: 0x0600CB8F RID: 52111 RVA: 0x003B21AF File Offset: 0x003B03AF
		public static bool isInGroup
		{
			get
			{
				return GroupManager.m_IsInGroup;
			}
			set
			{
				GroupManager.m_IsInGroup = value;
			}
		}

		// Token: 0x0400E00D RID: 57357
		private static bool m_IsInGroup;
	}
}
