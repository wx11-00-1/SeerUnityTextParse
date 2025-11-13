using System;

namespace core.model
{
	// Token: 0x02001958 RID: 6488
	public class PetListInfo
	{
		// Token: 0x0600CC16 RID: 52246 RVA: 0x003B4553 File Offset: 0x003B2753
		public PetListInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.id = (int)data.ReadUnsignedInt();
				this.isBright = (data.ReadUnsignedInt() > 0U);
				this.catchTime = (int)data.ReadUnsignedInt();
			}
		}

		// Token: 0x0400E218 RID: 57880
		public int id;

		// Token: 0x0400E219 RID: 57881
		public bool isBright;

		// Token: 0x0400E21A RID: 57882
		public int catchTime;

		// Token: 0x0400E21B RID: 57883
		public int abilityType;

		// Token: 0x0400E21C RID: 57884
		public int starTime;

		// Token: 0x0400E21D RID: 57885
		public int duration;

		// Token: 0x0400E21E RID: 57886
		public int course;

		// Token: 0x0400E21F RID: 57887
		public int level;
	}
}
