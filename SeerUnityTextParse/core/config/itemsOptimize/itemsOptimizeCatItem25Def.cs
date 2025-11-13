using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EE1 RID: 7905
	public class itemsOptimizeCatItem25Def : ItemData
	{
		// Token: 0x0600ECA3 RID: 60579 RVA: 0x003F05B4 File Offset: 0x003EE7B4
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600ECA4 RID: 60580 RVA: 0x003F05BC File Offset: 0x003EE7BC
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600ECA5 RID: 60581 RVA: 0x003F05C4 File Offset: 0x003EE7C4
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600ECA6 RID: 60582 RVA: 0x003F05CC File Offset: 0x003EE7CC
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600ECA7 RID: 60583 RVA: 0x003F05D4 File Offset: 0x003EE7D4
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600ECA8 RID: 60584 RVA: 0x003F05DF File Offset: 0x003EE7DF
		public override int GetLifeTime()
		{
			return this.LifeTime;
		}

		// Token: 0x0600ECA9 RID: 60585 RVA: 0x003F05E7 File Offset: 0x003EE7E7
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600ECAA RID: 60586 RVA: 0x003F05EF File Offset: 0x003EE7EF
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600ECAB RID: 60587 RVA: 0x003F05F7 File Offset: 0x003EE7F7
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600ECAC RID: 60588 RVA: 0x003F05FF File Offset: 0x003EE7FF
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600ECAD RID: 60589 RVA: 0x003F0608 File Offset: 0x003EE808
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EFF3 RID: 61427
		public int catID;

		// Token: 0x0400EFF4 RID: 61428
		public int ID;

		// Token: 0x0400EFF5 RID: 61429
		public string Name;

		// Token: 0x0400EFF6 RID: 61430
		public int Max;

		// Token: 0x0400EFF7 RID: 61431
		public int Hide;

		// Token: 0x0400EFF8 RID: 61432
		public int LifeTime;

		// Token: 0x0400EFF9 RID: 61433
		public int Rarity;

		// Token: 0x0400EFFA RID: 61434
		public int wd;

		// Token: 0x0400EFFB RID: 61435
		public int Sort;

		// Token: 0x0400EFFC RID: 61436
		public int UseMax;
	}
}
