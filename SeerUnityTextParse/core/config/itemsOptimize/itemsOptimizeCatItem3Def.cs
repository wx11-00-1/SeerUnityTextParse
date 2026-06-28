using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028D4 RID: 10452
	public class itemsOptimizeCatItem3Def : ItemData
	{
		// Token: 0x06015006 RID: 86022 RVA: 0x0057D58C File Offset: 0x0057B78C
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

		// Token: 0x04013F76 RID: 81782
		public int catID;

		// Token: 0x04013F77 RID: 81783
		public int ID;

		// Token: 0x04013F78 RID: 81784
		public string Name;

		// Token: 0x04013F79 RID: 81785
		public int Max;

		// Token: 0x04013F7A RID: 81786
		public int Bean;

		// Token: 0x04013F7B RID: 81787
		public int EvRemove;

		// Token: 0x04013F7C RID: 81788
		public int Hide;

		// Token: 0x04013F7D RID: 81789
		public int IncreMonLvTo;

		// Token: 0x04013F7E RID: 81790
		public int ItemType;

		// Token: 0x04013F7F RID: 81791
		public string LimitPetClass;

		// Token: 0x04013F80 RID: 81792
		public int PP;

		// Token: 0x04013F81 RID: 81793
		public int Price;

		// Token: 0x04013F82 RID: 81794
		public int purpose;

		// Token: 0x04013F83 RID: 81795
		public int Rarity;

		// Token: 0x04013F84 RID: 81796
		public int Sort;

		// Token: 0x04013F85 RID: 81797
		public int UseMax;

		// Token: 0x04013F86 RID: 81798
		public int VipOnly;

		// Token: 0x04013F87 RID: 81799
		public int wd;
	}
}
