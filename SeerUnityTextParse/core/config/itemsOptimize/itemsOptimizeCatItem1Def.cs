using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028D2 RID: 10450
	public class itemsOptimizeCatItem1Def : ItemData
	{
		// Token: 0x06015003 RID: 86019 RVA: 0x0057D474 File Offset: 0x0057B674
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

		// Token: 0x04013F64 RID: 81764
		public int catID;

		// Token: 0x04013F65 RID: 81765
		public int ID;

		// Token: 0x04013F66 RID: 81766
		public string Name;

		// Token: 0x04013F67 RID: 81767
		public int Max;

		// Token: 0x04013F68 RID: 81768
		public int RepairPrice;

		// Token: 0x04013F69 RID: 81769
		public int Bean;

		// Token: 0x04013F6A RID: 81770
		public int Hide;

		// Token: 0x04013F6B RID: 81771
		public int isSpecial;

		// Token: 0x04013F6C RID: 81772
		public int LifeTime;

		// Token: 0x04013F6D RID: 81773
		public int Price;

		// Token: 0x04013F6E RID: 81774
		public int purpose;

		// Token: 0x04013F6F RID: 81775
		public int Sort;

		// Token: 0x04013F70 RID: 81776
		public float speed;

		// Token: 0x04013F71 RID: 81777
		public string type;

		// Token: 0x04013F72 RID: 81778
		public int UseMax;

		// Token: 0x04013F73 RID: 81779
		public int VipOnly;

		// Token: 0x04013F74 RID: 81780
		public int wd;

		// Token: 0x04013F75 RID: 81781
		public int actionDir;
	}
}
