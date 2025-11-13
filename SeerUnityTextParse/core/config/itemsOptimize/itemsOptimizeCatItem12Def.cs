using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001ED9 RID: 7897
	public class itemsOptimizeCatItem12Def : ItemData
	{
		// Token: 0x0600EC2F RID: 60463 RVA: 0x003EFC4C File Offset: 0x003EDE4C
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC30 RID: 60464 RVA: 0x003EFC54 File Offset: 0x003EDE54
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC31 RID: 60465 RVA: 0x003EFC5C File Offset: 0x003EDE5C
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC32 RID: 60466 RVA: 0x003EFC64 File Offset: 0x003EDE64
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC33 RID: 60467 RVA: 0x003EFC6C File Offset: 0x003EDE6C
		public override int GetBean()
		{
			return 0;
		}

		// Token: 0x0600EC34 RID: 60468 RVA: 0x003EFC6F File Offset: 0x003EDE6F
		public override int GetExchangeId()
		{
			return this.ExchangeId;
		}

		// Token: 0x0600EC35 RID: 60469 RVA: 0x003EFC77 File Offset: 0x003EDE77
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600EC36 RID: 60470 RVA: 0x003EFC82 File Offset: 0x003EDE82
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC37 RID: 60471 RVA: 0x003EFC8A File Offset: 0x003EDE8A
		public override int GetTargetId()
		{
			return this.TargetId;
		}

		// Token: 0x0600EC38 RID: 60472 RVA: 0x003EFC92 File Offset: 0x003EDE92
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600EC39 RID: 60473 RVA: 0x003EFC9A File Offset: 0x003EDE9A
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600EC3A RID: 60474 RVA: 0x003EFCA2 File Offset: 0x003EDEA2
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC3B RID: 60475 RVA: 0x003EFCAC File Offset: 0x003EDEAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF8F RID: 61327
		public int catID;

		// Token: 0x0400EF90 RID: 61328
		public int ID;

		// Token: 0x0400EF91 RID: 61329
		public string Name;

		// Token: 0x0400EF92 RID: 61330
		public int Max;

		// Token: 0x0400EF93 RID: 61331
		public int Bean;

		// Token: 0x0400EF94 RID: 61332
		public int ExchangeId;

		// Token: 0x0400EF95 RID: 61333
		public int Hide;

		// Token: 0x0400EF96 RID: 61334
		public int purpose;

		// Token: 0x0400EF97 RID: 61335
		public int TargetId;

		// Token: 0x0400EF98 RID: 61336
		public int Rarity;

		// Token: 0x0400EF99 RID: 61337
		public int Sort;

		// Token: 0x0400EF9A RID: 61338
		public int wd;
	}
}
