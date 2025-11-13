using System;

namespace core.model
{
	// Token: 0x02001965 RID: 6501
	internal class PetTakeOutInfo
	{
		// Token: 0x0600CC3D RID: 52285 RVA: 0x003B51FC File Offset: 0x003B33FC
		public PetTakeOutInfo(ByteArray data)
		{
			this.m_homeEnergy = (int)data.ReadUnsignedInt();
			this.m_firstPetTime = (int)data.ReadUnsignedInt();
			this.m_flag = (int)data.ReadUnsignedInt();
			if (this.flag != 0)
			{
				//this.m_petInfo = new PetInfo(data, true, true, -1);
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x0600CC3E RID: 52286 RVA: 0x003B524A File Offset: 0x003B344A
		public int homeEnergy
		{
			get
			{
				return this.m_homeEnergy;
			}
		}

		// Token: 0x170010F7 RID: 4343
		// (get) Token: 0x0600CC3F RID: 52287 RVA: 0x003B5252 File Offset: 0x003B3452
		public int firstPetTime
		{
			get
			{
				return this.m_firstPetTime;
			}
		}

		// Token: 0x170010F8 RID: 4344
		// (get) Token: 0x0600CC40 RID: 52288 RVA: 0x003B525A File Offset: 0x003B345A
		public int flag
		{
			get
			{
				return this.m_flag;
			}
		}

		// Token: 0x170010F9 RID: 4345
		// (get) Token: 0x0600CC41 RID: 52289 RVA: 0x003B5262 File Offset: 0x003B3462
		//public PetInfo petInfo
		//{
		//	get
		//	{
		//		return this.m_petInfo;
		//	}
		//}

		// Token: 0x0400E29D RID: 58013
		private int m_homeEnergy;

		// Token: 0x0400E29E RID: 58014
		private int m_firstPetTime;

		// Token: 0x0400E29F RID: 58015
		private int m_flag;

		// Token: 0x0400E2A0 RID: 58016
		//private PetInfo m_petInfo;
	}
}
