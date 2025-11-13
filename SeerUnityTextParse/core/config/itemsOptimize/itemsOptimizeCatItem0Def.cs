using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001ED0 RID: 7888
	public class itemsOptimizeCatItem0Def : ItemData
	{
		// Token: 0x0600EC07 RID: 60423 RVA: 0x003EF528 File Offset: 0x003ED728
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hideNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF25 RID: 61221
		public int catID;

		// Token: 0x0400EF26 RID: 61222
		public int ID;

		// Token: 0x0400EF27 RID: 61223
		public string Name;

		// Token: 0x0400EF28 RID: 61224
		public int Max;

		// Token: 0x0400EF29 RID: 61225
		public int Bean;

		// Token: 0x0400EF2A RID: 61226
		public int Hide;

		// Token: 0x0400EF2B RID: 61227
		public int hideNum;

		// Token: 0x0400EF2C RID: 61228
		public int LifeTime;

		// Token: 0x0400EF2D RID: 61229
		public int Price;

		// Token: 0x0400EF2E RID: 61230
		public int purpose;

		// Token: 0x0400EF2F RID: 61231
		public int Rarity;

		// Token: 0x0400EF30 RID: 61232
		public int Sort;

		// Token: 0x0400EF31 RID: 61233
		public int UseMax;

		// Token: 0x0400EF32 RID: 61234
		public int wd;
	}
}
