using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001ED4 RID: 7892
	public class itemsOptimizeCatItem4Def : ItemData
	{
		// Token: 0x0600EC0E RID: 60430 RVA: 0x003EF824 File Offset: 0x003EDA24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF57 RID: 61271
		public int catID;

		// Token: 0x0400EF58 RID: 61272
		public int ID;

		// Token: 0x0400EF59 RID: 61273
		public string Name;

		// Token: 0x0400EF5A RID: 61274
		public int Max;

		// Token: 0x0400EF5B RID: 61275
		public int Bean;

		// Token: 0x0400EF5C RID: 61276
		public int Hide;

		// Token: 0x0400EF5D RID: 61277
		public int Price;

		// Token: 0x0400EF5E RID: 61278
		public int purpose;

		// Token: 0x0400EF5F RID: 61279
		public int Rarity;

		// Token: 0x0400EF60 RID: 61280
		public int Sort;

		// Token: 0x0400EF61 RID: 61281
		public int UseMax;

		// Token: 0x0400EF62 RID: 61282
		public int VipOnly;

		// Token: 0x0400EF63 RID: 61283
		public int wd;
	}
}
