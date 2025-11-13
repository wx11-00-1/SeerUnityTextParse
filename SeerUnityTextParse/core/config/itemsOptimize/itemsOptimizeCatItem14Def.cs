using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EDB RID: 7899
	public class itemsOptimizeCatItem14Def : ItemData
	{
		// Token: 0x0600EC4D RID: 60493 RVA: 0x003EFEB9 File Offset: 0x003EE0B9
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC4E RID: 60494 RVA: 0x003EFEC1 File Offset: 0x003EE0C1
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC4F RID: 60495 RVA: 0x003EFEC9 File Offset: 0x003EE0C9
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC50 RID: 60496 RVA: 0x003EFED1 File Offset: 0x003EE0D1
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC51 RID: 60497 RVA: 0x003EFED9 File Offset: 0x003EE0D9
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600EC52 RID: 60498 RVA: 0x003EFEE1 File Offset: 0x003EE0E1
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600EC53 RID: 60499 RVA: 0x003EFEEC File Offset: 0x003EE0EC
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC54 RID: 60500 RVA: 0x003EFEF4 File Offset: 0x003EE0F4
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600EC55 RID: 60501 RVA: 0x003EFEFC File Offset: 0x003EE0FC
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600EC56 RID: 60502 RVA: 0x003EFF04 File Offset: 0x003EE104
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC57 RID: 60503 RVA: 0x003EFF0C File Offset: 0x003EE10C
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

		// Token: 0x0400EFA9 RID: 61353
		public int catID;

		// Token: 0x0400EFAA RID: 61354
		public int ID;

		// Token: 0x0400EFAB RID: 61355
		public string Name;

		// Token: 0x0400EFAC RID: 61356
		public int Max;

		// Token: 0x0400EFAD RID: 61357
		public int Bean;

		// Token: 0x0400EFAE RID: 61358
		public int Hide;

		// Token: 0x0400EFAF RID: 61359
		public int purpose;

		// Token: 0x0400EFB0 RID: 61360
		public int Rarity;

		// Token: 0x0400EFB1 RID: 61361
		public int Sort;

		// Token: 0x0400EFB2 RID: 61362
		public int wd;
	}
}
