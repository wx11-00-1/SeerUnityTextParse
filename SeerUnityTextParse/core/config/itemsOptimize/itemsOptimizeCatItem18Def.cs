using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EDE RID: 7902
	public class itemsOptimizeCatItem18Def : ItemData
	{
		// Token: 0x0600EC7C RID: 60540 RVA: 0x003F028E File Offset: 0x003EE48E
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC7D RID: 60541 RVA: 0x003F0296 File Offset: 0x003EE496
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC7E RID: 60542 RVA: 0x003F029E File Offset: 0x003EE49E
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC7F RID: 60543 RVA: 0x003F02A6 File Offset: 0x003EE4A6
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC80 RID: 60544 RVA: 0x003F02AE File Offset: 0x003EE4AE
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600EC81 RID: 60545 RVA: 0x003F02B6 File Offset: 0x003EE4B6
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600EC82 RID: 60546 RVA: 0x003F02C1 File Offset: 0x003EE4C1
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC83 RID: 60547 RVA: 0x003F02C9 File Offset: 0x003EE4C9
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600EC84 RID: 60548 RVA: 0x003F02D1 File Offset: 0x003EE4D1
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600EC85 RID: 60549 RVA: 0x003F02D9 File Offset: 0x003EE4D9
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC86 RID: 60550 RVA: 0x003F02E4 File Offset: 0x003EE4E4
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

		// Token: 0x0400EFD2 RID: 61394
		public int catID;

		// Token: 0x0400EFD3 RID: 61395
		public int ID;

		// Token: 0x0400EFD4 RID: 61396
		public string Name;

		// Token: 0x0400EFD5 RID: 61397
		public int Max;

		// Token: 0x0400EFD6 RID: 61398
		public int Bean;

		// Token: 0x0400EFD7 RID: 61399
		public int Hide;

		// Token: 0x0400EFD8 RID: 61400
		public int purpose;

		// Token: 0x0400EFD9 RID: 61401
		public int Rarity;

		// Token: 0x0400EFDA RID: 61402
		public int Sort;

		// Token: 0x0400EFDB RID: 61403
		public int wd;
	}
}
