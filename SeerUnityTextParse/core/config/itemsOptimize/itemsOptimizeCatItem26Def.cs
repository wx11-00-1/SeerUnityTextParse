using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EE2 RID: 7906
	public class itemsOptimizeCatItem26Def : ItemData
	{
		// Token: 0x0600ECAF RID: 60591 RVA: 0x003F06A6 File Offset: 0x003EE8A6
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600ECB0 RID: 60592 RVA: 0x003F06AE File Offset: 0x003EE8AE
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600ECB1 RID: 60593 RVA: 0x003F06B6 File Offset: 0x003EE8B6
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600ECB2 RID: 60594 RVA: 0x003F06BE File Offset: 0x003EE8BE
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600ECB3 RID: 60595 RVA: 0x003F06C6 File Offset: 0x003EE8C6
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600ECB4 RID: 60596 RVA: 0x003F06CE File Offset: 0x003EE8CE
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600ECB5 RID: 60597 RVA: 0x003F06D6 File Offset: 0x003EE8D6
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600ECB6 RID: 60598 RVA: 0x003F06DE File Offset: 0x003EE8DE
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600ECB7 RID: 60599 RVA: 0x003F06E8 File Offset: 0x003EE8E8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EFFD RID: 61437
		public int catID;

		// Token: 0x0400EFFE RID: 61438
		public int ID;

		// Token: 0x0400EFFF RID: 61439
		public string Name;

		// Token: 0x0400F000 RID: 61440
		public int Max;

		// Token: 0x0400F001 RID: 61441
		public int purpose;

		// Token: 0x0400F002 RID: 61442
		public int wd;

		// Token: 0x0400F003 RID: 61443
		public int Sort;

		// Token: 0x0400F004 RID: 61444
		public int UseMax;
	}
}
