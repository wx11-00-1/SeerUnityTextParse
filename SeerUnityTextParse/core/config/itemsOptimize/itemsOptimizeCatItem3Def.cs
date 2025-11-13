using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001ED3 RID: 7891
	public class itemsOptimizeCatItem3Def : ItemData
	{
		// Token: 0x0600EC0C RID: 60428 RVA: 0x003EF714 File Offset: 0x003ED914
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.EvRemove = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.IncreMonLvTo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ItemType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LimitPetClass = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.PP = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF45 RID: 61253
		public int catID;

		// Token: 0x0400EF46 RID: 61254
		public int ID;

		// Token: 0x0400EF47 RID: 61255
		public string Name;

		// Token: 0x0400EF48 RID: 61256
		public int Max;

		// Token: 0x0400EF49 RID: 61257
		public int Bean;

		// Token: 0x0400EF4A RID: 61258
		public int EvRemove;

		// Token: 0x0400EF4B RID: 61259
		public int Hide;

		// Token: 0x0400EF4C RID: 61260
		public int IncreMonLvTo;

		// Token: 0x0400EF4D RID: 61261
		public int ItemType;

		// Token: 0x0400EF4E RID: 61262
		public string LimitPetClass;

		// Token: 0x0400EF4F RID: 61263
		public int PP;

		// Token: 0x0400EF50 RID: 61264
		public int Price;

		// Token: 0x0400EF51 RID: 61265
		public int purpose;

		// Token: 0x0400EF52 RID: 61266
		public int Rarity;

		// Token: 0x0400EF53 RID: 61267
		public int Sort;

		// Token: 0x0400EF54 RID: 61268
		public int UseMax;

		// Token: 0x0400EF55 RID: 61269
		public int VipOnly;

		// Token: 0x0400EF56 RID: 61270
		public int wd;
	}
}
