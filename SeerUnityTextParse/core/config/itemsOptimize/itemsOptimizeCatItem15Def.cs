using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028DD RID: 10461
	public class itemsOptimizeCatItem15Def : ItemData
	{
		// Token: 0x06015053 RID: 86099 RVA: 0x0057DE22 File Offset: 0x0057C022
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x06015054 RID: 86100 RVA: 0x0057DE2A File Offset: 0x0057C02A
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x06015055 RID: 86101 RVA: 0x0057DE32 File Offset: 0x0057C032
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x06015056 RID: 86102 RVA: 0x0057DE3A File Offset: 0x0057C03A
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x06015057 RID: 86103 RVA: 0x0057DE42 File Offset: 0x0057C042
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x06015058 RID: 86104 RVA: 0x0057DE4A File Offset: 0x0057C04A
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x06015059 RID: 86105 RVA: 0x0057DE55 File Offset: 0x0057C055
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0601505A RID: 86106 RVA: 0x0057DE5D File Offset: 0x0057C05D
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0601505B RID: 86107 RVA: 0x0057DE65 File Offset: 0x0057C065
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0601505C RID: 86108 RVA: 0x0057DE6D File Offset: 0x0057C06D
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0601505D RID: 86109 RVA: 0x0057DE78 File Offset: 0x0057C078
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x04013FE4 RID: 81892
		public int catID;

		// Token: 0x04013FE5 RID: 81893
		public int ID;

		// Token: 0x04013FE6 RID: 81894
		public string Name;

		// Token: 0x04013FE7 RID: 81895
		public int Max;

		// Token: 0x04013FE8 RID: 81896
		public int Bean;

		// Token: 0x04013FE9 RID: 81897
		public int Hide;

		// Token: 0x04013FEA RID: 81898
		public int purpose;

		// Token: 0x04013FEB RID: 81899
		public int UseMax;

		// Token: 0x04013FEC RID: 81900
		public int Sort;

		// Token: 0x04013FED RID: 81901
		public int wd;
	}
}
