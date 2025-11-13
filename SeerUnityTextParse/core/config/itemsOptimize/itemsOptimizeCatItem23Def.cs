using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EDF RID: 7903
	public class itemsOptimizeCatItem23Def : ItemData
	{
		// Token: 0x0600EC88 RID: 60552 RVA: 0x003F0382 File Offset: 0x003EE582
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC89 RID: 60553 RVA: 0x003F038A File Offset: 0x003EE58A
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC8A RID: 60554 RVA: 0x003F0392 File Offset: 0x003EE592
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC8B RID: 60555 RVA: 0x003F039A File Offset: 0x003EE59A
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC8C RID: 60556 RVA: 0x003F03A2 File Offset: 0x003EE5A2
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600EC8D RID: 60557 RVA: 0x003F03AA File Offset: 0x003EE5AA
		public override string GetExchangeOutId()
		{
			return this.ExchangeOutId;
		}

		// Token: 0x0600EC8E RID: 60558 RVA: 0x003F03B2 File Offset: 0x003EE5B2
		public override string GetExchangeOutCnt()
		{
			return this.ExchangeOutCnt;
		}

		// Token: 0x0600EC8F RID: 60559 RVA: 0x003F03BA File Offset: 0x003EE5BA
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600EC90 RID: 60560 RVA: 0x003F03C5 File Offset: 0x003EE5C5
		public override int Geticon()
		{
			return this.icon;
		}

		// Token: 0x0600EC91 RID: 60561 RVA: 0x003F03CD File Offset: 0x003EE5CD
		public override int GetLifeTime()
		{
			return this.LifeTime;
		}

		// Token: 0x0600EC92 RID: 60562 RVA: 0x003F03D5 File Offset: 0x003EE5D5
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC93 RID: 60563 RVA: 0x003F03DD File Offset: 0x003EE5DD
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600EC94 RID: 60564 RVA: 0x003F03E5 File Offset: 0x003EE5E5
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600EC95 RID: 60565 RVA: 0x003F03ED File Offset: 0x003EE5ED
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC96 RID: 60566 RVA: 0x003F03F5 File Offset: 0x003EE5F5
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600EC97 RID: 60567 RVA: 0x003F0400 File Offset: 0x003EE600
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EFDC RID: 61404
		public int catID;

		// Token: 0x0400EFDD RID: 61405
		public int ID;

		// Token: 0x0400EFDE RID: 61406
		public string Name;

		// Token: 0x0400EFDF RID: 61407
		public int Max;

		// Token: 0x0400EFE0 RID: 61408
		public int Bean;

		// Token: 0x0400EFE1 RID: 61409
		public string ExchangeOutCnt;

		// Token: 0x0400EFE2 RID: 61410
		public string ExchangeOutId;

		// Token: 0x0400EFE3 RID: 61411
		public int Hide;

		// Token: 0x0400EFE4 RID: 61412
		public int icon;

		// Token: 0x0400EFE5 RID: 61413
		public int LifeTime;

		// Token: 0x0400EFE6 RID: 61414
		public int purpose;

		// Token: 0x0400EFE7 RID: 61415
		public int Rarity;

		// Token: 0x0400EFE8 RID: 61416
		public int Sort;

		// Token: 0x0400EFE9 RID: 61417
		public int wd;

		// Token: 0x0400EFEA RID: 61418
		public int UseMax;
	}
}
