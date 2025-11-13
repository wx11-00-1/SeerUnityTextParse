using System;
using System.Collections.Generic;

namespace core.model
{
	// Token: 0x0200196A RID: 6506
	public class UpdateSkillInfo
	{
		// Token: 0x0600CC5A RID: 52314 RVA: 0x003B5794 File Offset: 0x003B3994
		public UpdateSkillInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.m_PetCatchTime = (int)data.ReadUnsignedInt();
				int num = (int)data.ReadUnsignedInt();
				int num2 = (int)data.ReadUnsignedInt();
				for (int i = 0; i < num; i++)
				{
					this.m_ActiveSkills.Add((int)data.ReadUnsignedInt());
				}
				for (int j = 0; j < num2; j++)
				{
					this.m_UnactiveSkills.Add((int)data.ReadUnsignedInt());
				}
			}
		}

		// Token: 0x170010FB RID: 4347
		// (get) Token: 0x0600CC5B RID: 52315 RVA: 0x003B5814 File Offset: 0x003B3A14
		// (set) Token: 0x0600CC5C RID: 52316 RVA: 0x003B581C File Offset: 0x003B3A1C
		public int petCatchTime
		{
			get
			{
				return this.m_PetCatchTime;
			}
			set
			{
				this.m_PetCatchTime = value;
			}
		}

		// Token: 0x170010FC RID: 4348
		// (get) Token: 0x0600CC5D RID: 52317 RVA: 0x003B5825 File Offset: 0x003B3A25
		// (set) Token: 0x0600CC5E RID: 52318 RVA: 0x003B582D File Offset: 0x003B3A2D
		public List<int> activeSkills
		{
			get
			{
				return this.m_ActiveSkills;
			}
			set
			{
				this.m_ActiveSkills = value;
			}
		}

		// Token: 0x170010FD RID: 4349
		// (get) Token: 0x0600CC5F RID: 52319 RVA: 0x003B5836 File Offset: 0x003B3A36
		// (set) Token: 0x0600CC60 RID: 52320 RVA: 0x003B583E File Offset: 0x003B3A3E
		public List<int> unactiveSkills
		{
			get
			{
				return this.m_UnactiveSkills;
			}
			set
			{
				this.m_UnactiveSkills = value;
			}
		}

		// Token: 0x0400E2B0 RID: 58032
		private int m_PetCatchTime;

		// Token: 0x0400E2B1 RID: 58033
		private List<int> m_ActiveSkills = new List<int>();

		// Token: 0x0400E2B2 RID: 58034
		private List<int> m_UnactiveSkills = new List<int>();
	}
}
