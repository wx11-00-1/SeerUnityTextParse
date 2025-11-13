using System;

namespace core.model
{
	// Token: 0x02001940 RID: 6464
	public class InviteNoteInfo
	{
		// Token: 0x0600CBAC RID: 52140 RVA: 0x003B2389 File Offset: 0x003B0589
		public InviteNoteInfo(ByteArray data)
		{
			this.m_userID = (int)data.ReadUnsignedInt();
			this.m_nickName = data.ReadUTFByte(16);
			//this.m_mode = (FightModel)data.ReadUnsignedInt();
		}

		// Token: 0x170010C9 RID: 4297
		// (get) Token: 0x0600CBAD RID: 52141 RVA: 0x003B23B7 File Offset: 0x003B05B7
		public int userID
		{
			get
			{
				return this.m_userID;
			}
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x0600CBAE RID: 52142 RVA: 0x003B23BF File Offset: 0x003B05BF
		public string nickName
		{
			get
			{
				return this.m_nickName;
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x0600CBAF RID: 52143 RVA: 0x003B23C7 File Offset: 0x003B05C7
		//public FightModel mode
		//{
		//	get
		//	{
		//		return this.m_mode;
		//	}
		//}

		// Token: 0x0400E0EA RID: 57578
		private int m_userID;

		// Token: 0x0400E0EB RID: 57579
		private string m_nickName;

		// Token: 0x0400E0EC RID: 57580
		//private FightModel m_mode;
	}
}
