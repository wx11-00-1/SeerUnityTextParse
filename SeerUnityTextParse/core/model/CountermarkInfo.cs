using System;
using System.Collections.Generic;
using common;
using core.config;

namespace core.model
{
	// Token: 0x02001923 RID: 6435
	public class CountermarkInfo
	{
		// Token: 0x0600CA7F RID: 51839 RVA: 0x003B00E8 File Offset: 0x003AE2E8
		public CountermarkInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.markID = (int)data.ReadUnsignedInt();
				this.m_CatchTime = (int)data.ReadUnsignedInt();
				this.m_HoleType = (int)data.ReadUnsignedInt();
				this.m_ObtainTime = (int)data.ReadUnsignedInt();
				this.m_BindMonID = (int)data.ReadUnsignedInt();
				this.m_BindMoveID = (int)data.ReadUnsignedInt();
				this.m_AtkAdj = (int)data.ReadUnsignedInt();
				this.m_DefAdj = (int)data.ReadUnsignedInt();
				this.m_SpAtkAdj = (int)data.ReadUnsignedInt();
				this.m_SpDefAdj = (int)data.ReadUnsignedInt();
				this.m_SpdAdj = (int)data.ReadUnsignedInt();
				this.m_HpAdj = (int)data.ReadUnsignedInt();
				this.m_GemID = (int)data.ReadUnsignedInt();
				this.m_PkgPos = (int)data.ReadUnsignedInt();
			}
		}

		// Token: 0x0600CA80 RID: 51840 RVA: 0x003B01B0 File Offset: 0x003AE3B0
		public CountermarkInfo(int markID, int level, int gemID)
		{
			this.markID = markID;
			this.level = level;
			this.gemID = gemID;
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x0600CA81 RID: 51841 RVA: 0x003B01D4 File Offset: 0x003AE3D4
		// (set) Token: 0x0600CA82 RID: 51842 RVA: 0x003B01DC File Offset: 0x003AE3DC
		public int markID
		{
			get
			{
				return this.m_MarkID;
			}
			set
			{
				this.m_MarkID = value;
				this.m_ExtraAttri = ResetableSingleTon<CountermarkXMLInfo>.Ins.getExtraAttriValue(this.m_MarkID);
				this.m_MarkName = ResetableSingleTon<CountermarkXMLInfo>.Ins.getDes(this.m_MarkID);
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x0600CA83 RID: 51843 RVA: 0x003B0211 File Offset: 0x003AE411
		// (set) Token: 0x0600CA84 RID: 51844 RVA: 0x003B0219 File Offset: 0x003AE419
		public int catchTime
		{
			get
			{
				return this.m_CatchTime;
			}
			set
			{
				this.m_CatchTime = value;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x0600CA85 RID: 51845 RVA: 0x003B0222 File Offset: 0x003AE422
		// (set) Token: 0x0600CA86 RID: 51846 RVA: 0x003B022A File Offset: 0x003AE42A
		public int holeType
		{
			get
			{
				return this.m_HoleType;
			}
			set
			{
				this.m_HoleType = value;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x0600CA87 RID: 51847 RVA: 0x003B0233 File Offset: 0x003AE433
		// (set) Token: 0x0600CA88 RID: 51848 RVA: 0x003B023B File Offset: 0x003AE43B
		public int obtainTime
		{
			get
			{
				return this.m_ObtainTime;
			}
			set
			{
				this.m_ObtainTime = value;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x0600CA89 RID: 51849 RVA: 0x003B0244 File Offset: 0x003AE444
		// (set) Token: 0x0600CA8A RID: 51850 RVA: 0x003B024C File Offset: 0x003AE44C
		public int bindMonID
		{
			get
			{
				return this.m_BindMonID;
			}
			set
			{
				this.m_BindMonID = value;
			}
		}

		// Token: 0x17001032 RID: 4146
		// (get) Token: 0x0600CA8B RID: 51851 RVA: 0x003B0255 File Offset: 0x003AE455
		// (set) Token: 0x0600CA8C RID: 51852 RVA: 0x003B025D File Offset: 0x003AE45D
		public int bindMoveID
		{
			get
			{
				return this.m_BindMoveID;
			}
			set
			{
				this.m_BindMoveID = value;
			}
		}

		// Token: 0x17001033 RID: 4147
		// (get) Token: 0x0600CA8D RID: 51853 RVA: 0x003B0266 File Offset: 0x003AE466
		// (set) Token: 0x0600CA8E RID: 51854 RVA: 0x003B026E File Offset: 0x003AE46E
		public int attackAdj
		{
			get
			{
				return this.m_AtkAdj;
			}
			set
			{
				this.m_AtkAdj = value;
			}
		}

		// Token: 0x17001034 RID: 4148
		// (get) Token: 0x0600CA8F RID: 51855 RVA: 0x003B0277 File Offset: 0x003AE477
		// (set) Token: 0x0600CA90 RID: 51856 RVA: 0x003B027F File Offset: 0x003AE47F
		public int defenceAdj
		{
			get
			{
				return this.m_DefAdj;
			}
			set
			{
				this.m_DefAdj = value;
			}
		}

		// Token: 0x17001035 RID: 4149
		// (get) Token: 0x0600CA91 RID: 51857 RVA: 0x003B0288 File Offset: 0x003AE488
		// (set) Token: 0x0600CA92 RID: 51858 RVA: 0x003B0290 File Offset: 0x003AE490
		public int spAttackAdj
		{
			get
			{
				return this.m_SpAtkAdj;
			}
			set
			{
				this.m_SpAtkAdj = value;
			}
		}

		// Token: 0x17001036 RID: 4150
		// (get) Token: 0x0600CA93 RID: 51859 RVA: 0x003B0299 File Offset: 0x003AE499
		// (set) Token: 0x0600CA94 RID: 51860 RVA: 0x003B02A1 File Offset: 0x003AE4A1
		public int spDefenceAdj
		{
			get
			{
				return this.m_SpDefAdj;
			}
			set
			{
				this.m_SpDefAdj = value;
			}
		}

		// Token: 0x17001037 RID: 4151
		// (get) Token: 0x0600CA95 RID: 51861 RVA: 0x003B02AA File Offset: 0x003AE4AA
		// (set) Token: 0x0600CA96 RID: 51862 RVA: 0x003B02B2 File Offset: 0x003AE4B2
		public int speedAdj
		{
			get
			{
				return this.m_SpdAdj;
			}
			set
			{
				this.m_SpdAdj = value;
			}
		}

		// Token: 0x17001038 RID: 4152
		// (get) Token: 0x0600CA97 RID: 51863 RVA: 0x003B02BB File Offset: 0x003AE4BB
		// (set) Token: 0x0600CA98 RID: 51864 RVA: 0x003B02C3 File Offset: 0x003AE4C3
		public int hpAdj
		{
			get
			{
				return this.m_HpAdj;
			}
			set
			{
				this.m_HpAdj = value;
			}
		}

		// Token: 0x17001039 RID: 4153
		// (get) Token: 0x0600CA99 RID: 51865 RVA: 0x003B02CC File Offset: 0x003AE4CC
		// (set) Token: 0x0600CA9A RID: 51866 RVA: 0x003B02D4 File Offset: 0x003AE4D4
		public int gemID
		{
			get
			{
				return this.m_GemID;
			}
			set
			{
				this.m_GemID = value;
			}
		}

		// Token: 0x1700103A RID: 4154
		// (get) Token: 0x0600CA9B RID: 51867 RVA: 0x003B02DD File Offset: 0x003AE4DD
		// (set) Token: 0x0600CA9C RID: 51868 RVA: 0x003B02E5 File Offset: 0x003AE4E5
		public int packagePosition
		{
			get
			{
				return this.m_PkgPos;
			}
			set
			{
				this.m_PkgPos = value;
			}
		}

		// Token: 0x1700103B RID: 4155
		// (get) Token: 0x0600CA9D RID: 51869 RVA: 0x003B02EE File Offset: 0x003AE4EE
		public bool isBindMon
		{
			get
			{
				return this.m_BindMonID > 0;
			}
		}

		// Token: 0x1700103C RID: 4156
		// (get) Token: 0x0600CA9E RID: 51870 RVA: 0x003B02F9 File Offset: 0x003AE4F9
		public bool isInstall
		{
			get
			{
				return this.m_CatchTime > 0;
			}
		}

		// Token: 0x1700103D RID: 4157
		// (get) Token: 0x0600CA9F RID: 51871 RVA: 0x003B0304 File Offset: 0x003AE504
		public bool isBindMove
		{
			get
			{
				return this.m_BindMoveID > 0;
			}
		}

		// Token: 0x1700103E RID: 4158
		// (get) Token: 0x0600CAA0 RID: 51872 RVA: 0x003B030F File Offset: 0x003AE50F
		public bool isBindGem
		{
			get
			{
				return this.m_GemID > 0;
			}
		}

		// Token: 0x1700103F RID: 4159
		// (get) Token: 0x0600CAA1 RID: 51873 RVA: 0x003B031A File Offset: 0x003AE51A
		public bool hasExtraAttri
		{
			get
			{
				return this.extraAttri != null && this.extraAttri.Count > 0;
			}
		}

		// Token: 0x17001040 RID: 4160
		// (get) Token: 0x0600CAA3 RID: 51875 RVA: 0x003B036C File Offset: 0x003AE56C
		// (set) Token: 0x0600CAA2 RID: 51874 RVA: 0x003B0334 File Offset: 0x003AE534
		public int[] adjArray
		{
			get
			{
				return new int[]
				{
					this.m_AtkAdj,
					this.m_DefAdj,
					this.m_SpAtkAdj,
					this.m_SpDefAdj,
					this.m_SpdAdj,
					this.m_HpAdj
				};
			}
			set
			{
				this.m_AtkAdj = value[0];
				this.m_DefAdj = value[1];
				this.m_SpAtkAdj = value[2];
				this.m_SpDefAdj = value[3];
				this.m_SpdAdj = value[4];
				this.m_HpAdj = value[5];
			}
		}

		// Token: 0x0600CAA4 RID: 51876 RVA: 0x003B03AC File Offset: 0x003AE5AC
		public CountermarkInfo clone()
		{
			return new CountermarkInfo(null)
			{
				markID = this.m_MarkID,
				catchTime = this.m_CatchTime,
				holeType = this.m_HoleType,
				obtainTime = this.m_ObtainTime,
				bindMonID = this.m_BindMonID,
				bindMoveID = this.m_BindMoveID,
				attackAdj = this.m_AtkAdj,
				defenceAdj = this.m_DefAdj,
				spAttackAdj = this.m_SpAtkAdj,
				spDefenceAdj = this.m_SpDefAdj,
				speedAdj = this.m_SpdAdj,
				hpAdj = this.m_HpAdj,
				gemID = this.m_GemID,
				packagePosition = this.m_PkgPos,
				level = this.level,
				extraAttri = this.extraAttri,
				markName = this.m_MarkName
			};
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x0600CAA5 RID: 51877 RVA: 0x003B048B File Offset: 0x003AE68B
		// (set) Token: 0x0600CAA6 RID: 51878 RVA: 0x003B04C8 File Offset: 0x003AE6C8
		public int level
		{
			get
			{
				if (this.m_Level == -1)
				{
					this.m_Level = ResetableSingleTon<CountermarkXMLInfo>.Ins.getCurrentGrade(this.m_MarkID, this.adjArray);
				}
				if (this.m_Level > 5)
				{
					this.m_Level = 5;
				}
				return this.m_Level;
			}
			set
			{
				this.m_Level = value;
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x0600CAA7 RID: 51879 RVA: 0x003B04D1 File Offset: 0x003AE6D1
		// (set) Token: 0x0600CAA8 RID: 51880 RVA: 0x003B04D9 File Offset: 0x003AE6D9
		public List<int> extraAttri
		{
			get
			{
				return this.m_ExtraAttri;
			}
			set
			{
				this.m_ExtraAttri = value;
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x0600CAA9 RID: 51881 RVA: 0x003B04E2 File Offset: 0x003AE6E2
		// (set) Token: 0x0600CAAA RID: 51882 RVA: 0x003B04EA File Offset: 0x003AE6EA
		public string markName
		{
			get
			{
				return this.m_MarkName;
			}
			set
			{
				this.m_MarkName = value;
			}
		}

		// Token: 0x0400DF49 RID: 57161
		private int m_MarkID;

		// Token: 0x0400DF4A RID: 57162
		private string m_MarkName;

		// Token: 0x0400DF4B RID: 57163
		private int m_CatchTime;

		// Token: 0x0400DF4C RID: 57164
		private int m_HoleType;

		// Token: 0x0400DF4D RID: 57165
		private int m_ObtainTime;

		// Token: 0x0400DF4E RID: 57166
		private int m_BindMonID;

		// Token: 0x0400DF4F RID: 57167
		private int m_BindMoveID;

		// Token: 0x0400DF50 RID: 57168
		private int m_AtkAdj;

		// Token: 0x0400DF51 RID: 57169
		private int m_DefAdj;

		// Token: 0x0400DF52 RID: 57170
		private int m_SpAtkAdj;

		// Token: 0x0400DF53 RID: 57171
		private int m_SpDefAdj;

		// Token: 0x0400DF54 RID: 57172
		private int m_SpdAdj;

		// Token: 0x0400DF55 RID: 57173
		private int m_HpAdj;

		// Token: 0x0400DF56 RID: 57174
		private int m_GemID;

		// Token: 0x0400DF57 RID: 57175
		private int m_PkgPos;

		// Token: 0x0400DF58 RID: 57176
		private int m_Level = -1;

		// Token: 0x0400DF59 RID: 57177
		private List<int> m_ExtraAttri;

		// Token: 0x0400DF5A RID: 57178
		public int mergeNum;
	}
}
