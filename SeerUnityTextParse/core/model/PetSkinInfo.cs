using System;
using common;
using core.config;
using core.config.pet_skin;

namespace core.model
{
	// Token: 0x02001960 RID: 6496
	public class PetSkinInfo
	{
		// Token: 0x0600CC32 RID: 52274 RVA: 0x003B4ED0 File Offset: 0x003B30D0
		public PetSkinInfo(ISkinItem info = null)
		{
			if (info != null)
			{
				this.config = info;
				this.id = info.ID;
				this.name = info.Name;
				this.monId = info.MonID;
				this.skinPetId = ResetableSingleTon<PetXMLInfo>.Ins.getRealId(1400000 + this.id);
				this.type = info.Type;
				this.go = info.Go;
				this.goType = info.GoType;
			}
		}

		// Token: 0x0600CC33 RID: 52275 RVA: 0x003B4F51 File Offset: 0x003B3151
		[Obsolete("请使用PetSkinXMLInfo.Ins.getPetDefaultSkin")]
		public static void getPetDefaultSkin()
		{
		}

		// Token: 0x0400E272 RID: 57970
		public int id;

		// Token: 0x0400E273 RID: 57971
		public int type;

		// Token: 0x0400E274 RID: 57972
		public int monId;

		// Token: 0x0400E275 RID: 57973
		public int shopId;

		// Token: 0x0400E276 RID: 57974
		public int skinPetId;

		// Token: 0x0400E277 RID: 57975
		public string go;

		// Token: 0x0400E278 RID: 57976
		public string name;

		// Token: 0x0400E279 RID: 57977
		public string goType;

		// Token: 0x0400E27A RID: 57978
		public ISkinItem config;
	}
}
