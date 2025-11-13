using System;
using System.Collections.Generic;
using common;
using core.config;

namespace core.model
{
	// Token: 0x02001963 RID: 6499
	public class PetStoragePetInfo
	{
		// Token: 0x0600CC37 RID: 52279 RVA: 0x003B4FB0 File Offset: 0x003B31B0
		//public PetStoragePetInfo(PetInfo petInfo, int storagePositionType = 0)
		//{
		//	this.id = petInfo.id;
		//	this.type = ResetableSingleTon<PetXMLInfo>.Ins.getType(this.id);
		//	this.posi = storagePositionType;
		//	this.level = petInfo.level;
		//	this.skinId = petInfo.skinId;
		//	this.catchTime = petInfo.catchTime;
		//	this.fifthSkill = ((petInfo.hideSKill == null) ? 0 : petInfo.hideSKill.id);
		//	this.effectCount = ((petInfo.effectList == null) ? 0 : petInfo.effectList.Count);
		//	this.effectList = petInfo.effectList;
		//}

		// Token: 0x0600CC38 RID: 52280 RVA: 0x003B5054 File Offset: 0x003B3254
		public PetStoragePetInfo(ByteArray data = null)
		{
			if (data != null)
			{
				this.id = data.ReadSignedInt();
				this.type = ResetableSingleTon<PetXMLInfo>.Ins.getType(this.id);
				this.catchTime = data.ReadSignedInt();
				this.posi = data.ReadSignedInt();
				this.level = data.ReadSignedInt();
			}
		}

		// Token: 0x0600CC39 RID: 52281 RVA: 0x003B50B0 File Offset: 0x003B32B0
		public PetStoragePetInfo(ByteArray data, bool isNew)
		{
			this.id = data.ReadSignedInt();
			this.type = ResetableSingleTon<PetXMLInfo>.Ins.getType(this.id);
			this.catchTime = data.ReadSignedInt();
			this.posi = data.ReadSignedInt();
			this.level = data.ReadSignedInt();
			this.skinId = data.ReadSignedInt();
			this.fifthSkill = data.ReadSignedInt();
			this.effectCount = data.ReadSignedInt();
			this.effectList = new List<PetEffectInfo>();
			for (int i = 0; i < this.effectCount; i++)
			{
				this.effectList.Add(new PetEffectInfo(data));
			}
		}


		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x0600CC3B RID: 52283 RVA: 0x003B51E1 File Offset: 0x003B33E1
		public string name
		{
			get
			{
				return ResetableSingleTon<PetXMLInfo>.Ins.getName(this.id);
			}
		}

		// Token: 0x0400E286 RID: 57990
		public int id;

		// Token: 0x0400E287 RID: 57991
		public int type;

		// Token: 0x0400E288 RID: 57992
		public int posi;

		// Token: 0x0400E289 RID: 57993
		public int level;

		// Token: 0x0400E28A RID: 57994
		public int skinId;

		// Token: 0x0400E28B RID: 57995
		public int catchTime;

		// Token: 0x0400E28C RID: 57996
		public int fifthSkill;

		// Token: 0x0400E28D RID: 57997
		public int effectCount;

		// Token: 0x0400E28E RID: 57998
		public List<PetEffectInfo> effectList;

		// Token: 0x0400E28F RID: 57999
		//private PetInfo m_petInfo;
	}
}
