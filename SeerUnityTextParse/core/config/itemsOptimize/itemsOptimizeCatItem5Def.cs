using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028D6 RID: 10454
	public class itemsOptimizeCatItem5Def : ItemData
	{
		// Token: 0x0601500A RID: 86026 RVA: 0x0057D761 File Offset: 0x0057B961
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0601500B RID: 86027 RVA: 0x0057D76C File Offset: 0x0057B96C
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

		// Token: 0x04013F95 RID: 81813
		public int catID;

		// Token: 0x04013F96 RID: 81814
		public int ID;

		// Token: 0x04013F97 RID: 81815
		public string Name;

		// Token: 0x04013F98 RID: 81816
		public int Max;

		// Token: 0x04013F99 RID: 81817
		public int Bean;

		// Token: 0x04013F9A RID: 81818
		public int Hide;

		// Token: 0x04013F9B RID: 81819
		public int Price;

		// Token: 0x04013F9C RID: 81820
		public int purpose;

		// Token: 0x04013F9D RID: 81821
		public int Sort;

		// Token: 0x04013F9E RID: 81822
		public int VipOnly;

		// Token: 0x04013F9F RID: 81823
		public int wd;
	}
}
