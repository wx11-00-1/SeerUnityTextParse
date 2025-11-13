using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EDC RID: 7900
	public class itemsOptimizeCatItem15Def : ItemData
	{
		// Token: 0x0600EC59 RID: 60505 RVA: 0x003EFFAA File Offset: 0x003EE1AA
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC5A RID: 60506 RVA: 0x003EFFB2 File Offset: 0x003EE1B2
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC5B RID: 60507 RVA: 0x003EFFBA File Offset: 0x003EE1BA
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC5C RID: 60508 RVA: 0x003EFFC2 File Offset: 0x003EE1C2
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC5D RID: 60509 RVA: 0x003EFFCA File Offset: 0x003EE1CA
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600EC5E RID: 60510 RVA: 0x003EFFD2 File Offset: 0x003EE1D2
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600EC5F RID: 60511 RVA: 0x003EFFDD File Offset: 0x003EE1DD
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC60 RID: 60512 RVA: 0x003EFFE5 File Offset: 0x003EE1E5
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600EC61 RID: 60513 RVA: 0x003EFFED File Offset: 0x003EE1ED
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600EC62 RID: 60514 RVA: 0x003EFFF5 File Offset: 0x003EE1F5
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC63 RID: 60515 RVA: 0x003F0000 File Offset: 0x003EE200
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

		// Token: 0x0400EFB3 RID: 61363
		public int catID;

		// Token: 0x0400EFB4 RID: 61364
		public int ID;

		// Token: 0x0400EFB5 RID: 61365
		public string Name;

		// Token: 0x0400EFB6 RID: 61366
		public int Max;

		// Token: 0x0400EFB7 RID: 61367
		public int Bean;

		// Token: 0x0400EFB8 RID: 61368
		public int Hide;

		// Token: 0x0400EFB9 RID: 61369
		public int purpose;

		// Token: 0x0400EFBA RID: 61370
		public int UseMax;

		// Token: 0x0400EFBB RID: 61371
		public int Sort;

		// Token: 0x0400EFBC RID: 61372
		public int wd;
	}
}
