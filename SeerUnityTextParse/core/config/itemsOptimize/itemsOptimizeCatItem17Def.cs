using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EDD RID: 7901
	public class itemsOptimizeCatItem17Def : ItemData
	{
		// Token: 0x0600EC65 RID: 60517 RVA: 0x003F009E File Offset: 0x003EE29E
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC66 RID: 60518 RVA: 0x003F00A6 File Offset: 0x003EE2A6
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC67 RID: 60519 RVA: 0x003F00AE File Offset: 0x003EE2AE
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC68 RID: 60520 RVA: 0x003F00B6 File Offset: 0x003EE2B6
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC69 RID: 60521 RVA: 0x003F00BE File Offset: 0x003EE2BE
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600EC6A RID: 60522 RVA: 0x003F00C6 File Offset: 0x003EE2C6
		public override string GetExchangeOutId()
		{
			return this.ExchangeOutId;
		}

		// Token: 0x0600EC6B RID: 60523 RVA: 0x003F00CE File Offset: 0x003EE2CE
		public override string GetExchangeOutCnt()
		{
			return this.ExchangeOutCnt;
		}

		// Token: 0x0600EC6C RID: 60524 RVA: 0x003F00D6 File Offset: 0x003EE2D6
		public override int GetExchangeId()
		{
			return this.ExchangeId;
		}

		// Token: 0x0600EC6D RID: 60525 RVA: 0x003F00DE File Offset: 0x003EE2DE
		public override int GetExchangeType()
		{
			return this.ExchangeType;
		}

		// Token: 0x0600EC6E RID: 60526 RVA: 0x003F00E6 File Offset: 0x003EE2E6
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600EC6F RID: 60527 RVA: 0x003F00F1 File Offset: 0x003EE2F1
		public override int GethideNum()
		{
			return this.hideNum;
		}

		// Token: 0x0600EC70 RID: 60528 RVA: 0x003F00F9 File Offset: 0x003EE2F9
		public override int GetItemType()
		{
			return this.ItemType;
		}

		// Token: 0x0600EC71 RID: 60529 RVA: 0x003F0101 File Offset: 0x003EE301
		public override int GetLifeTime()
		{
			return this.LifeTime;
		}

		// Token: 0x0600EC72 RID: 60530 RVA: 0x003F0109 File Offset: 0x003EE309
		public override int GetPrice()
		{
			return this.Price;
		}

		// Token: 0x0600EC73 RID: 60531 RVA: 0x003F0111 File Offset: 0x003EE311
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC74 RID: 60532 RVA: 0x003F0119 File Offset: 0x003EE319
		public override int GetTargetId()
		{
			return this.TargetId;
		}

		// Token: 0x0600EC75 RID: 60533 RVA: 0x003F0121 File Offset: 0x003EE321
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600EC76 RID: 60534 RVA: 0x003F0129 File Offset: 0x003EE329
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600EC77 RID: 60535 RVA: 0x003F0131 File Offset: 0x003EE331
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC78 RID: 60536 RVA: 0x003F0139 File Offset: 0x003EE339
		public override string GetUseEnd()
		{
			return this.UseEnd;
		}

		// Token: 0x0600EC79 RID: 60537 RVA: 0x003F0141 File Offset: 0x003EE341
		public override int GetSkinId()
		{
			return this.SkinId;
		}

		// Token: 0x0600EC7A RID: 60538 RVA: 0x003F014C File Offset: 0x003EE34C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hideNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ItemType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseEnd = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.SkinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EFBD RID: 61373
		public int catID;

		// Token: 0x0400EFBE RID: 61374
		public int ID;

		// Token: 0x0400EFBF RID: 61375
		public string Name;

		// Token: 0x0400EFC0 RID: 61376
		public int Max;

		// Token: 0x0400EFC1 RID: 61377
		public int Bean;

		// Token: 0x0400EFC2 RID: 61378
		public string ExchangeOutCnt;

		// Token: 0x0400EFC3 RID: 61379
		public string ExchangeOutId;

		// Token: 0x0400EFC4 RID: 61380
		public int ExchangeId;

		// Token: 0x0400EFC5 RID: 61381
		public int ExchangeType;

		// Token: 0x0400EFC6 RID: 61382
		public int Hide;

		// Token: 0x0400EFC7 RID: 61383
		public int hideNum;

		// Token: 0x0400EFC8 RID: 61384
		public int ItemType;

		// Token: 0x0400EFC9 RID: 61385
		public int LifeTime;

		// Token: 0x0400EFCA RID: 61386
		public int Price;

		// Token: 0x0400EFCB RID: 61387
		public int purpose;

		// Token: 0x0400EFCC RID: 61388
		public int TargetId;

		// Token: 0x0400EFCD RID: 61389
		public int Rarity;

		// Token: 0x0400EFCE RID: 61390
		public int Sort;

		// Token: 0x0400EFCF RID: 61391
		public int wd;

		// Token: 0x0400EFD0 RID: 61392
		public string UseEnd;

		// Token: 0x0400EFD1 RID: 61393
		public int SkinId;
	}
}
