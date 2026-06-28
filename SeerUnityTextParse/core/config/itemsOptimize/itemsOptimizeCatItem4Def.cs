using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028D5 RID: 10453
	public class itemsOptimizeCatItem4Def : ItemData
	{
		// Token: 0x06015008 RID: 86024 RVA: 0x0057D69C File Offset: 0x0057B89C
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

		// Token: 0x04013F88 RID: 81800
		public int catID;

		// Token: 0x04013F89 RID: 81801
		public int ID;

		// Token: 0x04013F8A RID: 81802
		public string Name;

		// Token: 0x04013F8B RID: 81803
		public int Max;

		// Token: 0x04013F8C RID: 81804
		public int Bean;

		// Token: 0x04013F8D RID: 81805
		public int Hide;

		// Token: 0x04013F8E RID: 81806
		public int Price;

		// Token: 0x04013F8F RID: 81807
		public int purpose;

		// Token: 0x04013F90 RID: 81808
		public int Rarity;

		// Token: 0x04013F91 RID: 81809
		public int Sort;

		// Token: 0x04013F92 RID: 81810
		public int UseMax;

		// Token: 0x04013F93 RID: 81811
		public int VipOnly;

		// Token: 0x04013F94 RID: 81812
		public int wd;
	}
}
