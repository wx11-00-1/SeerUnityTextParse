using System;
using core.manager;

namespace core.model
{
	// Token: 0x0200197B RID: 6523
	public class SimpleTeamInfo
	{
		// Token: 0x0600CC90 RID: 52368 RVA: 0x003B5E50 File Offset: 0x003B4050
		public SimpleTeamInfo(ByteArray data = null)
		{
			if (data == null)
			{
				return;
			}
			data.position = 0;
			this.m_TeamID = (int)data.ReadUnsignedInt();
			this.m_Leader = (int)data.ReadUnsignedInt();
			this.m_SuperCoreNum = (int)data.ReadUnsignedInt();
			this.m_MemberCount = (int)data.ReadUnsignedInt();
			this.m_Interest = (int)data.ReadUnsignedInt();
			this.m_JoinFlag = (int)data.ReadUnsignedInt();
			this.m_VisitFlag = (int)data.ReadUnsignedInt();
			this.m_Score = (int)data.ReadUnsignedInt();
			this.m_Exp = (int)data.ReadUnsignedInt();
			this.m_Name = data.ReadUTFByte(16);
			this.m_Slogan = data.ReadUTFByte(60);
			this.m_Notice = data.ReadUTFByte(60);
			this.m_LogoBg = (int)data.ReadSignedShort();
			this.m_LogoIcon = (int)data.ReadSignedShort();
			this.m_LogoColor = (int)data.ReadSignedShort();
			this.m_TxtColor = (int)data.ReadSignedShort();
			this.m_LogoWord = data.ReadUTFByte(4);
			this.newTeamLevel = (int)data.ReadUnsignedInt();
			this.techCenterLevel = (int)data.ReadUnsignedInt();
			this.bonusCenterLevel = (int)data.ReadUnsignedInt();
			this.resCenterLevel = (int)data.ReadUnsignedInt();
			this.m_DrawingUint = (int)data.ReadUnsignedInt();
			this.totalBossDmg = (int)data.ReadUnsignedInt();
			this.team_func_disalbed = (int)data.ReadUnsignedInt();
			this.lastPayTime = (int)data.ReadUnsignedInt();
			this.teamPkInfo = new TeamPkHistoryInfo(data);
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x0600CC91 RID: 52369 RVA: 0x003B5FAD File Offset: 0x003B41AD
		// (set) Token: 0x0600CC92 RID: 52370 RVA: 0x003B5FB5 File Offset: 0x003B41B5
		public int logoBg
		{
			get
			{
				return this.m_LogoBg;
			}
			set
			{
				this.m_LogoBg = value;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x0600CC93 RID: 52371 RVA: 0x003B5FBE File Offset: 0x003B41BE
		// (set) Token: 0x0600CC94 RID: 52372 RVA: 0x003B5FC6 File Offset: 0x003B41C6
		public int logoIcon
		{
			get
			{
				return this.m_LogoIcon;
			}
			set
			{
				this.m_LogoIcon = value;
			}
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x0600CC95 RID: 52373 RVA: 0x003B5FCF File Offset: 0x003B41CF
		// (set) Token: 0x0600CC96 RID: 52374 RVA: 0x003B5FD7 File Offset: 0x003B41D7
		public int logoColor
		{
			get
			{
				return this.m_LogoColor;
			}
			set
			{
				this.m_LogoColor = value;
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x0600CC97 RID: 52375 RVA: 0x003B5FE0 File Offset: 0x003B41E0
		// (set) Token: 0x0600CC98 RID: 52376 RVA: 0x003B5FE8 File Offset: 0x003B41E8
		public int txtColor
		{
			get
			{
				return this.m_TxtColor;
			}
			set
			{
				this.m_TxtColor = value;
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x0600CC99 RID: 52377 RVA: 0x003B5FF1 File Offset: 0x003B41F1
		// (set) Token: 0x0600CC9A RID: 52378 RVA: 0x003B5FF9 File Offset: 0x003B41F9
		public string logoWord
		{
			get
			{
				return this.m_LogoWord;
			}
			set
			{
				this.m_LogoWord = value;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x0600CC9B RID: 52379 RVA: 0x003B6002 File Offset: 0x003B4202
		// (set) Token: 0x0600CC9C RID: 52380 RVA: 0x003B600A File Offset: 0x003B420A
		public int superCoreNum
		{
			get
			{
				return this.m_SuperCoreNum;
			}
			set
			{
				this.m_SuperCoreNum = value;
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x0600CC9D RID: 52381 RVA: 0x003B6013 File Offset: 0x003B4213
		// (set) Token: 0x0600CC9E RID: 52382 RVA: 0x003B601B File Offset: 0x003B421B
		public int exp
		{
			get
			{
				return this.m_Exp;
			}
			set
			{
				this.m_Exp = value;
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x0600CC9F RID: 52383 RVA: 0x003B6024 File Offset: 0x003B4224
		// (set) Token: 0x0600CCA0 RID: 52384 RVA: 0x003B602C File Offset: 0x003B422C
		public int score
		{
			get
			{
				return this.m_Score;
			}
			set
			{
				this.m_Score = value;
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x0600CCA1 RID: 52385 RVA: 0x003B6035 File Offset: 0x003B4235
		// (set) Token: 0x0600CCA2 RID: 52386 RVA: 0x003B603D File Offset: 0x003B423D
		public int teamID
		{
			get
			{
				return this.m_TeamID;
			}
			set
			{
				this.m_TeamID = value;
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x0600CCA3 RID: 52387 RVA: 0x003B6046 File Offset: 0x003B4246
		// (set) Token: 0x0600CCA4 RID: 52388 RVA: 0x003B604E File Offset: 0x003B424E
		public int leader
		{
			get
			{
				return this.m_Leader;
			}
			set
			{
				this.m_Leader = value;
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x0600CCA5 RID: 52389 RVA: 0x003B6057 File Offset: 0x003B4257
		// (set) Token: 0x0600CCA6 RID: 52390 RVA: 0x003B605F File Offset: 0x003B425F
		public int memberCount
		{
			get
			{
				return this.m_MemberCount;
			}
			set
			{
				this.m_MemberCount = value;
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x0600CCA7 RID: 52391 RVA: 0x003B6068 File Offset: 0x003B4268
		public int numbererest
		{
			get
			{
				return this.m_Interest;
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x0600CCA8 RID: 52392 RVA: 0x003B6070 File Offset: 0x003B4270
		// (set) Token: 0x0600CCA9 RID: 52393 RVA: 0x003B6078 File Offset: 0x003B4278
		public int joinFlag
		{
			get
			{
				return this.m_JoinFlag;
			}
			set
			{
				this.m_JoinFlag = value;
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x0600CCAA RID: 52394 RVA: 0x003B6081 File Offset: 0x003B4281
		public int visitFlag
		{
			get
			{
				return this.m_VisitFlag;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x0600CCAB RID: 52395 RVA: 0x003B6089 File Offset: 0x003B4289
		// (set) Token: 0x0600CCAC RID: 52396 RVA: 0x003B6091 File Offset: 0x003B4291
		public string name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x0600CCAD RID: 52397 RVA: 0x003B609A File Offset: 0x003B429A
		// (set) Token: 0x0600CCAE RID: 52398 RVA: 0x003B60A2 File Offset: 0x003B42A2
		public string slogan
		{
			get
			{
				return this.m_Slogan;
			}
			set
			{
				this.m_Slogan = value;
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x0600CCAF RID: 52399 RVA: 0x003B60AB File Offset: 0x003B42AB
		// (set) Token: 0x0600CCB0 RID: 52400 RVA: 0x003B60B3 File Offset: 0x003B42B3
		public string notice
		{
			get
			{
				return this.m_Notice;
			}
			set
			{
				this.m_Notice = value;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x0600CCB1 RID: 52401 RVA: 0x003B60BC File Offset: 0x003B42BC
		public int level
		{
			get
			{
				int num = 2;
				for (int i = (int)this.countExp(num); i < this.m_Exp; i = (int)this.countExp(num))
				{
					num++;
				}
				int num2 = num - 1;
				if (num2 > 100)
				{
					num2 = 100;
				}
				return num2;
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600CCB2 RID: 52402 RVA: 0x003B60FC File Offset: 0x003B42FC
		public int realLevel
		{
			get
			{
				int num = 2;
				for (int i = (int)this.countExp(num); i < this.m_Exp; i = (int)this.countExp(num))
				{
					num++;
				}
				return num - 1;
			}
		}

		// Token: 0x0600CCB3 RID: 52403 RVA: 0x003B6130 File Offset: 0x003B4330
		public double countExp(int i)
		{
			return Math.Ceiling(6.0 * Math.Pow((double)i, 3.0) / 5.0 - 15.0 * Math.Pow((double)i, 2.0) + (double)(100 * i) - 140.0);
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600CCB4 RID: 52404 RVA: 0x003B6191 File Offset: 0x003B4391
		// (set) Token: 0x0600CCB5 RID: 52405 RVA: 0x003B6199 File Offset: 0x003B4399
		public string leaderNick
		{
			get
			{
				return this.m_LeaderNick;
			}
			set
			{
				this.m_LeaderNick = value;
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x0600CCB6 RID: 52406 RVA: 0x003B61A4 File Offset: 0x003B43A4
		public int weeklyCost
		{
			get
			{
				int num = this.newTeamLevel * 40 + 120;
				if (this.newTeamLevel == 10)
				{
					num += 40;
				}
				return num + this.weeklyBonusCost + this.weeklyTechCost;
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x0600CCB7 RID: 52407 RVA: 0x003B61DC File Offset: 0x003B43DC
		public int weeklyTechCost
		{
			get
			{
				int num = this.techCenterLevel * 20 + 60;
				if (this.techCenterLevel == 10)
				{
					num += 20;
				}
				return num;
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x0600CCB8 RID: 52408 RVA: 0x003B6208 File Offset: 0x003B4408
		public int weeklyBonusCost
		{
			get
			{
				int num = this.bonusCenterLevel * 20 + 60;
				if (this.bonusCenterLevel == 10)
				{
					num += 20;
				}
				return num;
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x0600CCB9 RID: 52409 RVA: 0x003B6234 File Offset: 0x003B4434
		public int[] weeklyNextLv
		{
			get
			{
				int[] array = new int[2];
				if (this.newTeamLevel == 10)
				{
					return array;
				}
				int num = this.newTeamLevel * 100 + 400;
				if (this.newTeamLevel == 9)
				{
					num += 100;
				}
				int num2 = (this.newTeamLevel + 1) * 40 + 120;
				if (this.newTeamLevel + 1 == 10)
				{
					num2 += 40;
				}
				array[0] = num;
				array[1] = num2 + this.weeklyBonusCost + this.weeklyTechCost;
				return array;
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x0600CCBA RID: 52410 RVA: 0x003B62AC File Offset: 0x003B44AC
		public int[] weeklyTechNextLv
		{
			get
			{
				int[] array = new int[2];
				if (this.techCenterLevel == 10)
				{
					return array;
				}
				int num = this.techCenterLevel * 50 + 200;
				if (this.techCenterLevel == 9)
				{
					num += 50;
				}
				int num2 = (this.techCenterLevel + 1) * 20 + 60;
				if (this.techCenterLevel + 1 == 10)
				{
					num2 += 20;
				}
				array[0] = num;
				array[1] = num2;
				return array;
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x0600CCBB RID: 52411 RVA: 0x003B6314 File Offset: 0x003B4514
		public int[] weeklyBonusNextLv
		{
			get
			{
				int[] array = new int[2];
				if (this.bonusCenterLevel == 10)
				{
					return array;
				}
				int num = this.bonusCenterLevel * 50 + 200;
				if (this.bonusCenterLevel == 9)
				{
					num += 50;
				}
				int num2 = (this.bonusCenterLevel + 1) * 20 + 60;
				if (this.bonusCenterLevel + 1 == 10)
				{
					num2 += 20;
				}
				array[0] = num;
				array[1] = num2;
				return array;
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x0600CCBC RID: 52412 RVA: 0x003B637C File Offset: 0x003B457C
		//public int nextPayday
		//{
		//	get
		//	{
		//		int num = (int)((SystemTimerManager.time - (long)this.lastPayTime) / 86400L);
		//		return 7 - num;
		//	}
		//}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x0600CCBD RID: 52413 RVA: 0x003B63A2 File Offset: 0x003B45A2
		public int maxTeamMembers
		{
			get
			{
				return 70;
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x0600CCBE RID: 52414 RVA: 0x003B63A6 File Offset: 0x003B45A6
		// (set) Token: 0x0600CCBF RID: 52415 RVA: 0x003B63AE File Offset: 0x003B45AE
		public int haveDrawingStatus
		{
			get
			{
				return this.m_DrawingUint;
			}
			set
			{
				this.m_DrawingUint = value;
			}
		}

		// Token: 0x0400E2FC RID: 58108
		private int m_TeamID;

		// Token: 0x0400E2FD RID: 58109
		private int m_Leader;

		// Token: 0x0400E2FE RID: 58110
		private int m_MemberCount;

		// Token: 0x0400E2FF RID: 58111
		private int m_Interest;

		// Token: 0x0400E300 RID: 58112
		private int m_JoinFlag;

		// Token: 0x0400E301 RID: 58113
		private int m_VisitFlag;

		// Token: 0x0400E302 RID: 58114
		private int m_Exp;

		// Token: 0x0400E303 RID: 58115
		private int m_Score;

		// Token: 0x0400E304 RID: 58116
		public string m_Name;

		// Token: 0x0400E305 RID: 58117
		private string m_Slogan;

		// Token: 0x0400E306 RID: 58118
		private string m_Notice;

		// Token: 0x0400E307 RID: 58119
		private string m_LeaderNick;

		// Token: 0x0400E308 RID: 58120
		private int m_LogoBg;

		// Token: 0x0400E309 RID: 58121
		private int m_LogoIcon;

		// Token: 0x0400E30A RID: 58122
		private int m_LogoColor;

		// Token: 0x0400E30B RID: 58123
		private int m_TxtColor;

		// Token: 0x0400E30C RID: 58124
		private string m_LogoWord;

		// Token: 0x0400E30D RID: 58125
		private int m_DrawingUint;

		// Token: 0x0400E30E RID: 58126
		private int m_SuperCoreNum;

		// Token: 0x0400E30F RID: 58127
		public int newTeamLevel;

		// Token: 0x0400E310 RID: 58128
		public int techCenterLevel;

		// Token: 0x0400E311 RID: 58129
		public int bonusCenterLevel;

		// Token: 0x0400E312 RID: 58130
		public int resCenterLevel;

		// Token: 0x0400E313 RID: 58131
		public int totalBossDmg;

		// Token: 0x0400E314 RID: 58132
		public int team_func_disalbed;

		// Token: 0x0400E315 RID: 58133
		public int lastPayTime;

		// Token: 0x0400E316 RID: 58134
		public TeamPkHistoryInfo teamPkInfo;

		// Token: 0x0400E317 RID: 58135
		public bool applyFlag;
	}
}
