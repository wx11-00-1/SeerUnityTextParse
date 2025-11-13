using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001ED5 RID: 7893
	public class itemsOptimizeCatItem5Def : ItemData
	{
		// Token: 0x0600EC10 RID: 60432 RVA: 0x003EF8E9 File Offset: 0x003EDAE9
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC11 RID: 60433 RVA: 0x003EF8F4 File Offset: 0x003EDAF4
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
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF64 RID: 61284
		public int catID;

		// Token: 0x0400EF65 RID: 61285
		public int ID;

		// Token: 0x0400EF66 RID: 61286
		public string Name;

		// Token: 0x0400EF67 RID: 61287
		public int Max;

		// Token: 0x0400EF68 RID: 61288
		public int Bean;

		// Token: 0x0400EF69 RID: 61289
		public int Hide;

		// Token: 0x0400EF6A RID: 61290
		public int Price;

		// Token: 0x0400EF6B RID: 61291
		public int purpose;

		// Token: 0x0400EF6C RID: 61292
		public int Sort;

		// Token: 0x0400EF6D RID: 61293
		public int VipOnly;

		// Token: 0x0400EF6E RID: 61294
		public int wd;
	}
}
