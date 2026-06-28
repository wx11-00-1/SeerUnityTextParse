using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028D9 RID: 10457
	public class itemsOptimizeCatItem11Def : ItemData
	{
		// Token: 0x0601501B RID: 86043 RVA: 0x0057D9AA File Offset: 0x0057BBAA
		public override int GetSelfType()
		{
			return this.Type;
		}

		// Token: 0x0601501C RID: 86044 RVA: 0x0057D9B2 File Offset: 0x0057BBB2
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0601501D RID: 86045 RVA: 0x0057D9BA File Offset: 0x0057BBBA
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0601501E RID: 86046 RVA: 0x0057D9C2 File Offset: 0x0057BBC2
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0601501F RID: 86047 RVA: 0x0057D9CA File Offset: 0x0057BBCA
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x06015020 RID: 86048 RVA: 0x0057D9D2 File Offset: 0x0057BBD2
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x06015021 RID: 86049 RVA: 0x0057D9DA File Offset: 0x0057BBDA
		public override int GetNeedLv()
		{
			return this.NeedLv;
		}

		// Token: 0x06015022 RID: 86050 RVA: 0x0057D9E2 File Offset: 0x0057BBE2
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x06015023 RID: 86051 RVA: 0x0057D9EA File Offset: 0x0057BBEA
		public override int GetRank()
		{
			return this.Rank;
		}

		// Token: 0x06015024 RID: 86052 RVA: 0x0057D9F2 File Offset: 0x0057BBF2
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x06015025 RID: 86053 RVA: 0x0057D9FA File Offset: 0x0057BBFA
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x06015026 RID: 86054 RVA: 0x0057DA02 File Offset: 0x0057BC02
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x06015027 RID: 86055 RVA: 0x0057DA0C File Offset: 0x0057BC0C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NeedLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x04013FB4 RID: 81844
		public int catID;

		// Token: 0x04013FB5 RID: 81845
		public int ID;

		// Token: 0x04013FB6 RID: 81846
		public string Name;

		// Token: 0x04013FB7 RID: 81847
		public int Max;

		// Token: 0x04013FB8 RID: 81848
		public int Bean;

		// Token: 0x04013FB9 RID: 81849
		public int NeedLv;

		// Token: 0x04013FBA RID: 81850
		public int purpose;

		// Token: 0x04013FBB RID: 81851
		public int Rank;

		// Token: 0x04013FBC RID: 81852
		public int Rarity;

		// Token: 0x04013FBD RID: 81853
		public int Sort;

		// Token: 0x04013FBE RID: 81854
		public int wd;

		// Token: 0x04013FBF RID: 81855
		public int Type;
	}
}
