using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028DF RID: 10463
	public class itemsOptimizeCatItem18Def : ItemData
	{
		// Token: 0x06015076 RID: 86134 RVA: 0x0057E106 File Offset: 0x0057C306
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x06015077 RID: 86135 RVA: 0x0057E10E File Offset: 0x0057C30E
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x06015078 RID: 86136 RVA: 0x0057E116 File Offset: 0x0057C316
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x06015079 RID: 86137 RVA: 0x0057E11E File Offset: 0x0057C31E
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0601507A RID: 86138 RVA: 0x0057E126 File Offset: 0x0057C326
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0601507B RID: 86139 RVA: 0x0057E12E File Offset: 0x0057C32E
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0601507C RID: 86140 RVA: 0x0057E139 File Offset: 0x0057C339
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0601507D RID: 86141 RVA: 0x0057E141 File Offset: 0x0057C341
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0601507E RID: 86142 RVA: 0x0057E149 File Offset: 0x0057C349
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0601507F RID: 86143 RVA: 0x0057E151 File Offset: 0x0057C351
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x06015080 RID: 86144 RVA: 0x0057E15C File Offset: 0x0057C35C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x04014003 RID: 81923
		public int catID;

		// Token: 0x04014004 RID: 81924
		public int ID;

		// Token: 0x04014005 RID: 81925
		public string Name;

		// Token: 0x04014006 RID: 81926
		public int Max;

		// Token: 0x04014007 RID: 81927
		public int Bean;

		// Token: 0x04014008 RID: 81928
		public int Hide;

		// Token: 0x04014009 RID: 81929
		public int purpose;

		// Token: 0x0401400A RID: 81930
		public int Rarity;

		// Token: 0x0401400B RID: 81931
		public int Sort;

		// Token: 0x0401400C RID: 81932
		public int wd;
	}
}
