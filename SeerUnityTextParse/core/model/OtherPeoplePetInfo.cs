using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x0200194D RID: 6477
	public class OtherPeoplePetInfo
	{
		// Token: 0x0600CBDE RID: 52190 RVA: 0x003B2EAC File Offset: 0x003B10AC
		public OtherPeoplePetInfo(ByteArray data)
		{
			if (data == null)
			{
				return;
			}
			this.catchTime = (int)data.ReadUnsignedInt();
			this.useflag = (int)data.ReadUnsignedInt();
			this.id = (int)data.ReadUnsignedInt();
			this.level = (int)data.ReadUnsignedInt();
			this.dv = (int)data.ReadUnsignedInt();
			this.nature = (int)data.ReadUnsignedInt();
			this.hp = (int)data.ReadUnsignedInt();
			this.maxHp = (int)data.ReadUnsignedInt();
			this.maxhp_adj = (int)data.ReadUnsignedInt();
			this.atk = (int)data.ReadUnsignedInt();
			this.atk_adj = (int)data.ReadUnsignedInt();
			this.sp_atk = (int)data.ReadUnsignedInt();
			this.spatk_adj = (int)data.ReadUnsignedInt();
			this.def = (int)data.ReadUnsignedInt();
			this.def_adj = (int)data.ReadUnsignedInt();
			this.sp_def = (int)data.ReadUnsignedInt();
			this.spdef_adj = (int)data.ReadUnsignedInt();
			this.spd = (int)data.ReadUnsignedInt();
			this.spd_adj = (int)data.ReadUnsignedInt();
			for (int i = 0; i < 6; i++)
			{
				this.evlistArray.Add((int)data.ReadUnsignedByte());
			}
			int num = (int)data.ReadUnsignedInt();
			for (int j = 0; j < 5; j++)
			{
				int num2 = (int)data.ReadUnsignedInt();
				int num3 = (int)data.ReadUnsignedInt();
				if (j < num)
				{
					this.skillArray.Add(new int[]
					{
						num2,
						num3
					});
				}
			}
			for (int k = 0; k < 6; k++)
			{
				this.activated_sp_movesArray.Add((int)data.ReadUnsignedInt());
			}
			for (int l = 0; l < 3; l++)
			{
				this.mintmarksArray.Add((int)data.ReadUnsignedInt());
			}
			this.common_slot_activated = (int)data.ReadUnsignedInt();
			this.skinId = (int)data.ReadUnsignedInt();
		}

		// Token: 0x0400E15E RID: 57694
		public int SKILL_NUM = 5;

		// Token: 0x0400E15F RID: 57695
		public int catchTime;

		// Token: 0x0400E160 RID: 57696
		public int useflag;

		// Token: 0x0400E161 RID: 57697
		public int id;

		// Token: 0x0400E162 RID: 57698
		public int level;

		// Token: 0x0400E163 RID: 57699
		public int dv;

		// Token: 0x0400E164 RID: 57700
		public int nature;

		// Token: 0x0400E165 RID: 57701
		public int hp;

		// Token: 0x0400E166 RID: 57702
		public int maxHp;

		// Token: 0x0400E167 RID: 57703
		public int maxhp_adj;

		// Token: 0x0400E168 RID: 57704
		public int atk;

		// Token: 0x0400E169 RID: 57705
		public int atk_adj;

		// Token: 0x0400E16A RID: 57706
		public int sp_atk;

		// Token: 0x0400E16B RID: 57707
		public int spatk_adj;

		// Token: 0x0400E16C RID: 57708
		public int def;

		// Token: 0x0400E16D RID: 57709
		public int def_adj;

		// Token: 0x0400E16E RID: 57710
		public int sp_def;

		// Token: 0x0400E16F RID: 57711
		public int spdef_adj;

		// Token: 0x0400E170 RID: 57712
		public int spd;

		// Token: 0x0400E171 RID: 57713
		public int spd_adj;

		// Token: 0x0400E172 RID: 57714
		public List<int> evlistArray = new List<int>();

		// Token: 0x0400E173 RID: 57715
		public List<int[]> skillArray = new List<int[]>();

		// Token: 0x0400E174 RID: 57716
		public List<int> activated_sp_movesArray = new List<int>();

		// Token: 0x0400E175 RID: 57717
		public List<int> mintmarksArray = new List<int>();

		// Token: 0x0400E176 RID: 57718
		public int common_slot_activated;

		// Token: 0x0400E177 RID: 57719
		public int skinId;
	}
}
