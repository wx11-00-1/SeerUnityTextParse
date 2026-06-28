using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028D8 RID: 10456
	public class itemsOptimizeCatItem10Def : ItemData
	{
		// Token: 0x0601500F RID: 86031 RVA: 0x0057D8B6 File Offset: 0x0057BAB6
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x06015010 RID: 86032 RVA: 0x0057D8BE File Offset: 0x0057BABE
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x06015011 RID: 86033 RVA: 0x0057D8C6 File Offset: 0x0057BAC6
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x06015012 RID: 86034 RVA: 0x0057D8CE File Offset: 0x0057BACE
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x06015013 RID: 86035 RVA: 0x0057D8D6 File Offset: 0x0057BAD6
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x06015014 RID: 86036 RVA: 0x0057D8DE File Offset: 0x0057BADE
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x06015015 RID: 86037 RVA: 0x0057D8E9 File Offset: 0x0057BAE9
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x06015016 RID: 86038 RVA: 0x0057D8F1 File Offset: 0x0057BAF1
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x06015017 RID: 86039 RVA: 0x0057D8F9 File Offset: 0x0057BAF9
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x06015018 RID: 86040 RVA: 0x0057D901 File Offset: 0x0057BB01
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x06015019 RID: 86041 RVA: 0x0057D90C File Offset: 0x0057BB0C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x04013FAA RID: 81834
		public int catID;

		// Token: 0x04013FAB RID: 81835
		public int ID;

		// Token: 0x04013FAC RID: 81836
		public string Name;

		// Token: 0x04013FAD RID: 81837
		public int Max;

		// Token: 0x04013FAE RID: 81838
		public int Bean;

		// Token: 0x04013FAF RID: 81839
		public int Hide;

		// Token: 0x04013FB0 RID: 81840
		public int purpose;

		// Token: 0x04013FB1 RID: 81841
		public int Sort;

		// Token: 0x04013FB2 RID: 81842
		public int UseMax;

		// Token: 0x04013FB3 RID: 81843
		public int wd;
	}
}
