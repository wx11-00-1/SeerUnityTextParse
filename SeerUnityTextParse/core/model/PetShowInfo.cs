using System;

namespace core.model
{
	// Token: 0x0200195B RID: 6491
	public class PetShowInfo
	{
		// Token: 0x0600CC1E RID: 52254 RVA: 0x003B4A98 File Offset: 0x003B2C98
		public PetShowInfo(ByteArray data = null)
		{
			if (data != null)
			{
				data.position = 0;
				this.userID = (int)data.ReadUnsignedInt();
				this.catchTime = (int)data.ReadUnsignedInt();
				this.petID = (int)data.ReadUnsignedInt();
				this.isBright = (data.ReadUnsignedInt() > 0U);
				this.abilityType = (int)data.ReadUnsignedInt();
				this.flag = (int)data.ReadUnsignedInt();
				this.otherPetId = (int)data.ReadUnsignedInt();
				this.otherBright = (data.ReadUnsignedInt() > 0U);
				this.otherAbilityType = (int)data.ReadUnsignedInt();
				this.otherEatBright = (data.ReadUnsignedInt() > 0U);
				this.skinId = (int)data.ReadUnsignedInt();
			}
		}

		// Token: 0x0600CC1F RID: 52255 RVA: 0x003B4B48 File Offset: 0x003B2D48
		public PetShowInfo clone()
		{
			return new PetShowInfo(null)
			{
				userID = this.userID,
				catchTime = this.catchTime,
				petID = this.petID,
				isBright = this.isBright,
				abilityType = this.abilityType,
				flag = this.flag,
				isEatBrigh = this.isEatBrigh,
				otherPetId = this.otherPetId,
				otherBright = this.otherBright,
				otherAbilityType = this.otherAbilityType,
				otherEatBright = this.otherEatBright
			};
		}

		// Token: 0x0400E242 RID: 57922
		public int userID;

		// Token: 0x0400E243 RID: 57923
		public int catchTime;

		// Token: 0x0400E244 RID: 57924
		public int petID;

		// Token: 0x0400E245 RID: 57925
		public bool isBright;

		// Token: 0x0400E246 RID: 57926
		public int abilityType;

		// Token: 0x0400E247 RID: 57927
		public int flag;

		// Token: 0x0400E248 RID: 57928
		public bool isEatBrigh;

		// Token: 0x0400E249 RID: 57929
		public int otherPetId;

		// Token: 0x0400E24A RID: 57930
		public bool otherBright;

		// Token: 0x0400E24B RID: 57931
		public int otherAbilityType;

		// Token: 0x0400E24C RID: 57932
		public bool otherEatBright;

		// Token: 0x0400E24D RID: 57933
		public int skinId;
	}
}
