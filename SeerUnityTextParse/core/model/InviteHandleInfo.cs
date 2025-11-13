using System;

namespace core.model
{
	// Token: 0x0200193F RID: 6463
	internal class InviteHandleInfo
	{
		// Token: 0x0600CBA8 RID: 52136 RVA: 0x003B2343 File Offset: 0x003B0543
		public InviteHandleInfo(ByteArray data)
		{
			this.m_userID = (int)data.ReadUnsignedInt();
			this.m_nickName = data.ReadUTFByte(16);
			this.m_result = (int)data.ReadUnsignedInt();
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600CBA9 RID: 52137 RVA: 0x003B2371 File Offset: 0x003B0571
		public int userID
		{
			get
			{
				return this.m_userID;
			}
		}

		// Token: 0x170010C7 RID: 4295
		// (get) Token: 0x0600CBAA RID: 52138 RVA: 0x003B2379 File Offset: 0x003B0579
		public string nickName
		{
			get
			{
				return this.m_nickName;
			}
		}

		// Token: 0x170010C8 RID: 4296
		// (get) Token: 0x0600CBAB RID: 52139 RVA: 0x003B2381 File Offset: 0x003B0581
		public int result
		{
			get
			{
				return this.m_result;
			}
		}

		// Token: 0x0400E0E7 RID: 57575
		private int m_userID;

		// Token: 0x0400E0E8 RID: 57576
		private string m_nickName;

		// Token: 0x0400E0E9 RID: 57577
		private int m_result;
	}
}
