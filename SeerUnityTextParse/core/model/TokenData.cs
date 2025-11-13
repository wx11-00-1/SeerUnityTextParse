using System;

namespace core.model
{
	// Token: 0x02001985 RID: 6533
	public class TokenData
	{
		// Token: 0x0600CCDE RID: 52446 RVA: 0x003B66E0 File Offset: 0x003B48E0
		public static TokenData parse(string token)
		{
			return new TokenData();
		}

		// Token: 0x0600CCDF RID: 52447 RVA: 0x003B66E7 File Offset: 0x003B48E7
		public static TokenData parseObj(object token)
		{
			return new TokenData();
		}

		// Token: 0x0400E359 RID: 58201
		public int uid;

		// Token: 0x0400E35A RID: 58202
		public string email;

		// Token: 0x0400E35B RID: 58203
		public int loginType;

		// Token: 0x0400E35C RID: 58204
		public string token;

		// Token: 0x0400E35D RID: 58205
		public string session;

		// Token: 0x0400E35E RID: 58206
		public string nick;
	}
}
