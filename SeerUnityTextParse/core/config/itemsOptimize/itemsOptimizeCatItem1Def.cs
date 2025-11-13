using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001ED1 RID: 7889
	public class itemsOptimizeCatItem1Def : ItemData
	{
		// Token: 0x0600EC09 RID: 60425 RVA: 0x003EF5FC File Offset: 0x003ED7FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RepairPrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isSpecial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.speed = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.actionDir = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF33 RID: 61235
		public int catID;

		// Token: 0x0400EF34 RID: 61236
		public int ID;

		// Token: 0x0400EF35 RID: 61237
		public string Name;

		// Token: 0x0400EF36 RID: 61238
		public int Max;

		// Token: 0x0400EF37 RID: 61239
		public int RepairPrice;

		// Token: 0x0400EF38 RID: 61240
		public int Bean;

		// Token: 0x0400EF39 RID: 61241
		public int Hide;

		// Token: 0x0400EF3A RID: 61242
		public int isSpecial;

		// Token: 0x0400EF3B RID: 61243
		public int LifeTime;

		// Token: 0x0400EF3C RID: 61244
		public int Price;

		// Token: 0x0400EF3D RID: 61245
		public int purpose;

		// Token: 0x0400EF3E RID: 61246
		public int Sort;

		// Token: 0x0400EF3F RID: 61247
		public float speed;

		// Token: 0x0400EF40 RID: 61248
		public string type;

		// Token: 0x0400EF41 RID: 61249
		public int UseMax;

		// Token: 0x0400EF42 RID: 61250
		public int VipOnly;

		// Token: 0x0400EF43 RID: 61251
		public int wd;

		// Token: 0x0400EF44 RID: 61252
		public int actionDir;
	}
}
