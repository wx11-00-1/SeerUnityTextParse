using System;

namespace core.model
{
	// Token: 0x02001987 RID: 6535
	public class UpdatePropInfo
	{
		// Token: 0x0600CCE1 RID: 52449 RVA: 0x003B66F8 File Offset: 0x003B48F8
		public UpdatePropInfo(ByteArray data)
		{
			this.m_catchTime = (int)data.ReadUnsignedInt();
			this.m_id = (int)data.ReadUnsignedInt();
			this.m_level = (int)data.ReadUnsignedInt();
			this.m_exp = (int)data.ReadUnsignedInt();
			this.m_expEgg = (int)data.ReadUnsignedInt();
			this.m_currentLvExp = (int)data.ReadUnsignedInt();
			this.m_nextLvExp = (int)data.ReadUnsignedInt();
			this.m_maxHp = (int)data.ReadUnsignedInt();
			this.m_attack = (int)data.ReadUnsignedInt();
			this.m_defence = (int)data.ReadUnsignedInt();
			this.m_sa = (int)data.ReadUnsignedInt();
			this.m_sd = (int)data.ReadUnsignedInt();
			this.m_sp = (int)data.ReadUnsignedInt();
			this.ev_hp = (int)data.ReadUnsignedInt();
			this.ev_a = (int)data.ReadUnsignedInt();
			this.ev_d = (int)data.ReadUnsignedInt();
			this.ev_sa = (int)data.ReadUnsignedInt();
			this.ev_sd = (int)data.ReadUnsignedInt();
			this.ev_sp = (int)data.ReadUnsignedInt();
		}

		// Token: 0x0600CCE2 RID: 52450 RVA: 0x003B67EF File Offset: 0x003B49EF
		public void update()
		{
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x0600CCE3 RID: 52451 RVA: 0x003B67F1 File Offset: 0x003B49F1
		public int catchTime
		{
			get
			{
				return this.m_catchTime;
			}
		}

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x0600CCE4 RID: 52452 RVA: 0x003B67F9 File Offset: 0x003B49F9
		public int id
		{
			get
			{
				return this.m_id;
			}
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x0600CCE5 RID: 52453 RVA: 0x003B6801 File Offset: 0x003B4A01
		public int level
		{
			get
			{
				return this.m_level;
			}
		}

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x0600CCE6 RID: 52454 RVA: 0x003B6809 File Offset: 0x003B4A09
		public int exp
		{
			get
			{
				return this.m_exp;
			}
		}

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x0600CCE7 RID: 52455 RVA: 0x003B6811 File Offset: 0x003B4A11
		public int currentLvExp
		{
			get
			{
				return this.m_currentLvExp;
			}
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x0600CCE8 RID: 52456 RVA: 0x003B6819 File Offset: 0x003B4A19
		public int nextLvExp
		{
			get
			{
				return this.m_nextLvExp;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x0600CCE9 RID: 52457 RVA: 0x003B6821 File Offset: 0x003B4A21
		public int maxHp
		{
			get
			{
				return this.m_maxHp;
			}
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600CCEA RID: 52458 RVA: 0x003B6829 File Offset: 0x003B4A29
		public int attack
		{
			get
			{
				return this.m_attack;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x0600CCEB RID: 52459 RVA: 0x003B6831 File Offset: 0x003B4A31
		public int defence
		{
			get
			{
				return this.m_defence;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x0600CCEC RID: 52460 RVA: 0x003B6839 File Offset: 0x003B4A39
		public int sa
		{
			get
			{
				return this.m_sa;
			}
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x0600CCED RID: 52461 RVA: 0x003B6841 File Offset: 0x003B4A41
		public int sd
		{
			get
			{
				return this.m_sd;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x0600CCEE RID: 52462 RVA: 0x003B6849 File Offset: 0x003B4A49
		public int sp
		{
			get
			{
				return this.m_sp;
			}
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x0600CCEF RID: 52463 RVA: 0x003B6851 File Offset: 0x003B4A51
		public int expEgg
		{
			get
			{
				return this.m_expEgg;
			}
		}

		// Token: 0x0400E365 RID: 58213
		private int m_catchTime;

		// Token: 0x0400E366 RID: 58214
		private int m_id;

		// Token: 0x0400E367 RID: 58215
		private int m_level;

		// Token: 0x0400E368 RID: 58216
		private int m_exp;

		// Token: 0x0400E369 RID: 58217
		private int m_expEgg;

		// Token: 0x0400E36A RID: 58218
		private int m_maxHp;

		// Token: 0x0400E36B RID: 58219
		private int m_attack;

		// Token: 0x0400E36C RID: 58220
		private int m_defence;

		// Token: 0x0400E36D RID: 58221
		private int m_sa;

		// Token: 0x0400E36E RID: 58222
		private int m_sd;

		// Token: 0x0400E36F RID: 58223
		private int m_sp;

		// Token: 0x0400E370 RID: 58224
		private int m_currentLvExp;

		// Token: 0x0400E371 RID: 58225
		private int m_nextLvExp;

		// Token: 0x0400E372 RID: 58226
		public int ev_hp;

		// Token: 0x0400E373 RID: 58227
		public int ev_a;

		// Token: 0x0400E374 RID: 58228
		public int ev_d;

		// Token: 0x0400E375 RID: 58229
		public int ev_sa;

		// Token: 0x0400E376 RID: 58230
		public int ev_sd;

		// Token: 0x0400E377 RID: 58231
		public int ev_sp;
	}
}
