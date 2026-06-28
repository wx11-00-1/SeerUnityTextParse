using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028DC RID: 10460
	public class itemsOptimizeCatItem14Def : ItemData
	{
		// Token: 0x06015047 RID: 86087 RVA: 0x0057DD31 File Offset: 0x0057BF31
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x06015048 RID: 86088 RVA: 0x0057DD39 File Offset: 0x0057BF39
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x06015049 RID: 86089 RVA: 0x0057DD41 File Offset: 0x0057BF41
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0601504A RID: 86090 RVA: 0x0057DD49 File Offset: 0x0057BF49
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0601504B RID: 86091 RVA: 0x0057DD51 File Offset: 0x0057BF51
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0601504C RID: 86092 RVA: 0x0057DD59 File Offset: 0x0057BF59
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0601504D RID: 86093 RVA: 0x0057DD64 File Offset: 0x0057BF64
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0601504E RID: 86094 RVA: 0x0057DD6C File Offset: 0x0057BF6C
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0601504F RID: 86095 RVA: 0x0057DD74 File Offset: 0x0057BF74
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x06015050 RID: 86096 RVA: 0x0057DD7C File Offset: 0x0057BF7C
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x06015051 RID: 86097 RVA: 0x0057DD84 File Offset: 0x0057BF84
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

		// Token: 0x04013FDA RID: 81882
		public int catID;

		// Token: 0x04013FDB RID: 81883
		public int ID;

		// Token: 0x04013FDC RID: 81884
		public string Name;

		// Token: 0x04013FDD RID: 81885
		public int Max;

		// Token: 0x04013FDE RID: 81886
		public int Bean;

		// Token: 0x04013FDF RID: 81887
		public int Hide;

		// Token: 0x04013FE0 RID: 81888
		public int purpose;

		// Token: 0x04013FE1 RID: 81889
		public int Rarity;

		// Token: 0x04013FE2 RID: 81890
		public int Sort;

		// Token: 0x04013FE3 RID: 81891
		public int wd;
	}
}
