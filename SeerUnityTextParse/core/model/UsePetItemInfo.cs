using System;

namespace core.model
{
	// Token: 0x02001988 RID: 6536
	public class UsePetItemInfo
	{
		// Token: 0x0600CCF0 RID: 52464 RVA: 0x003B6859 File Offset: 0x003B4A59
		public UsePetItemInfo()
		{
		}

		// Token: 0x0600CCF1 RID: 52465 RVA: 0x003B6861 File Offset: 0x003B4A61
		public void SetData(ByteArray data)
		{
			this.s_userID = (int)data.ReadUnsignedInt();
			this.s_itemID = (int)data.ReadUnsignedInt();
			this.s_uesrHP = (int)data.ReadUnsignedInt();
			this.changeHp = data.ReadSignedInt();
			this.round = data.ReadSignedInt();
		}

		// Token: 0x0600CCF2 RID: 52466 RVA: 0x003B689F File Offset: 0x003B4A9F
		public UsePetItemInfo(ByteArray data)
		{
			this.SetData(data);
		}

		// Token: 0x17001147 RID: 4423
		// (get) Token: 0x0600CCF3 RID: 52467 RVA: 0x003B68AE File Offset: 0x003B4AAE
		public int userID
		{
			get
			{
				return this.s_userID;
			}
		}

		// Token: 0x17001148 RID: 4424
		// (get) Token: 0x0600CCF4 RID: 52468 RVA: 0x003B68B6 File Offset: 0x003B4AB6
		public int itemID
		{
			get
			{
				return this.s_itemID;
			}
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x0600CCF5 RID: 52469 RVA: 0x003B68BE File Offset: 0x003B4ABE
		public int userHP
		{
			get
			{
				return this.s_uesrHP;
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x0600CCF6 RID: 52470 RVA: 0x003B68C6 File Offset: 0x003B4AC6
		// (set) Token: 0x0600CCF7 RID: 52471 RVA: 0x003B68CE File Offset: 0x003B4ACE
		public int round
		{
			get
			{
				return this.s_round;
			}
			set
			{
				this.s_round = value;
			}
		}

		// Token: 0x0600CCF8 RID: 52472 RVA: 0x003B68D8 File Offset: 0x003B4AD8
		public override string ToString()
		{
			return string.Format("{{\"userID\":{0},\"itemID\":{1},\"userHP\":{2},\"changeHp\":{3},\"round\":{4}}}", new object[]
			{
				this.userID,
				this.itemID,
				this.userHP,
				this.changeHp,
				this.round
			});
		}

		// Token: 0x0400E378 RID: 58232
		private int s_userID;

		// Token: 0x0400E379 RID: 58233
		private int s_itemID;

		// Token: 0x0400E37A RID: 58234
		private int s_uesrHP;

		// Token: 0x0400E37B RID: 58235
		private int s_round;

		// Token: 0x0400E37C RID: 58236
		public int changeHp;
	}
}
