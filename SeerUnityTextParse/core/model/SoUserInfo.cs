using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x02001978 RID: 6520
	public class SoUserInfo
	{
		// Token: 0x0600CC88 RID: 52360 RVA: 0x003B5D0C File Offset: 0x003B3F0C
		public SoUserInfo clone()
		{
			return new SoUserInfo
			{
				userID = this.userID,
				password = this.password,
				nickName = this.nickName,
				color = this.color,
				texture = this.texture,
				passwordo = this.passwordo,
				clothes = this.clothes,
				lastLogin = this.lastLogin,
				customID = this.customID,
				lastUsedID = this.lastUsedID,
				otherlogintype = this.otherlogintype
			};
		}

		// Token: 0x0400E2EA RID: 58090
		public int userID;

		// Token: 0x0400E2EB RID: 58091
		public string password = string.Empty;

		// Token: 0x0400E2EC RID: 58092
		public string nickName = string.Empty;

		// Token: 0x0400E2ED RID: 58093
		public int color;

		// Token: 0x0400E2EE RID: 58094
		public int texture;

		// Token: 0x0400E2EF RID: 58095
		public List<int> clothes;

		// Token: 0x0400E2F0 RID: 58096
		public DateTime lastLogin;

		// Token: 0x0400E2F1 RID: 58097
		public string passwordo = string.Empty;

		// Token: 0x0400E2F2 RID: 58098
		public string customID = string.Empty;

		// Token: 0x0400E2F3 RID: 58099
		public int lastUsedID = 1;

		// Token: 0x0400E2F4 RID: 58100
		public int otherlogintype;
	}
}
