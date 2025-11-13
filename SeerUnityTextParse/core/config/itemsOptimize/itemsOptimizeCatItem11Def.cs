using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001ED8 RID: 7896
	public class itemsOptimizeCatItem11Def : ItemData
	{
		// Token: 0x0600EC21 RID: 60449 RVA: 0x003EFB32 File Offset: 0x003EDD32
		public override int GetSelfType()
		{
			return this.Type;
		}

		// Token: 0x0600EC22 RID: 60450 RVA: 0x003EFB3A File Offset: 0x003EDD3A
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC23 RID: 60451 RVA: 0x003EFB42 File Offset: 0x003EDD42
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC24 RID: 60452 RVA: 0x003EFB4A File Offset: 0x003EDD4A
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC25 RID: 60453 RVA: 0x003EFB52 File Offset: 0x003EDD52
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC26 RID: 60454 RVA: 0x003EFB5A File Offset: 0x003EDD5A
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600EC27 RID: 60455 RVA: 0x003EFB62 File Offset: 0x003EDD62
		public override int GetNeedLv()
		{
			return this.NeedLv;
		}

		// Token: 0x0600EC28 RID: 60456 RVA: 0x003EFB6A File Offset: 0x003EDD6A
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC29 RID: 60457 RVA: 0x003EFB72 File Offset: 0x003EDD72
		public override int GetRank()
		{
			return this.Rank;
		}

		// Token: 0x0600EC2A RID: 60458 RVA: 0x003EFB7A File Offset: 0x003EDD7A
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600EC2B RID: 60459 RVA: 0x003EFB82 File Offset: 0x003EDD82
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600EC2C RID: 60460 RVA: 0x003EFB8A File Offset: 0x003EDD8A
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC2D RID: 60461 RVA: 0x003EFB94 File Offset: 0x003EDD94
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

		// Token: 0x0400EF83 RID: 61315
		public int catID;

		// Token: 0x0400EF84 RID: 61316
		public int ID;

		// Token: 0x0400EF85 RID: 61317
		public string Name;

		// Token: 0x0400EF86 RID: 61318
		public int Max;

		// Token: 0x0400EF87 RID: 61319
		public int Bean;

		// Token: 0x0400EF88 RID: 61320
		public int NeedLv;

		// Token: 0x0400EF89 RID: 61321
		public int purpose;

		// Token: 0x0400EF8A RID: 61322
		public int Rank;

		// Token: 0x0400EF8B RID: 61323
		public int Rarity;

		// Token: 0x0400EF8C RID: 61324
		public int Sort;

		// Token: 0x0400EF8D RID: 61325
		public int wd;

		// Token: 0x0400EF8E RID: 61326
		public int Type;
	}
}
