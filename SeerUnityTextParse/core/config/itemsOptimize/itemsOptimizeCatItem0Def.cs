using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028D1 RID: 10449
	public class itemsOptimizeCatItem0Def : ItemData
	{
		// Token: 0x06015001 RID: 86017 RVA: 0x0057D3A0 File Offset: 0x0057B5A0
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

		// Token: 0x04013F56 RID: 81750
		public int catID;

		// Token: 0x04013F57 RID: 81751
		public int ID;

		// Token: 0x04013F58 RID: 81752
		public string Name;

		// Token: 0x04013F59 RID: 81753
		public int Max;

		// Token: 0x04013F5A RID: 81754
		public int Bean;

		// Token: 0x04013F5B RID: 81755
		public int Hide;

		// Token: 0x04013F5C RID: 81756
		public int hideNum;

		// Token: 0x04013F5D RID: 81757
		public int LifeTime;

		// Token: 0x04013F5E RID: 81758
		public int Price;

		// Token: 0x04013F5F RID: 81759
		public int purpose;

		// Token: 0x04013F60 RID: 81760
		public int Rarity;

		// Token: 0x04013F61 RID: 81761
		public int Sort;

		// Token: 0x04013F62 RID: 81762
		public int UseMax;

		// Token: 0x04013F63 RID: 81763
		public int wd;
	}
}
