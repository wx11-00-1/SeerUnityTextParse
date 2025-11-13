using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EDA RID: 7898
	public class itemsOptimizeCatItem13Def : ItemData
	{
		// Token: 0x0600EC3D RID: 60477 RVA: 0x003EFD64 File Offset: 0x003EDF64
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC3E RID: 60478 RVA: 0x003EFD6C File Offset: 0x003EDF6C
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC3F RID: 60479 RVA: 0x003EFD74 File Offset: 0x003EDF74
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC40 RID: 60480 RVA: 0x003EFD7C File Offset: 0x003EDF7C
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC41 RID: 60481 RVA: 0x003EFD84 File Offset: 0x003EDF84
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600EC42 RID: 60482 RVA: 0x003EFD8C File Offset: 0x003EDF8C
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600EC43 RID: 60483 RVA: 0x003EFD97 File Offset: 0x003EDF97
		public override bool IsSpecial()
		{
			return this.isSpecial != 0;
		}

		// Token: 0x0600EC44 RID: 60484 RVA: 0x003EFDA2 File Offset: 0x003EDFA2
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC45 RID: 60485 RVA: 0x003EFDAA File Offset: 0x003EDFAA
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600EC46 RID: 60486 RVA: 0x003EFDB2 File Offset: 0x003EDFB2
		public override float Getspeed()
		{
			return this.speed;
		}

		// Token: 0x0600EC47 RID: 60487 RVA: 0x003EFDBA File Offset: 0x003EDFBA
		public override string Gettype()
		{
			return this.type;
		}

		// Token: 0x0600EC48 RID: 60488 RVA: 0x003EFDC2 File Offset: 0x003EDFC2
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600EC49 RID: 60489 RVA: 0x003EFDCA File Offset: 0x003EDFCA
		public override bool IsSuper()
		{
			return this.VipOnly != 0;
		}

		// Token: 0x0600EC4A RID: 60490 RVA: 0x003EFDD5 File Offset: 0x003EDFD5
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC4B RID: 60491 RVA: 0x003EFDE0 File Offset: 0x003EDFE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isSpecial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.speed = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF9B RID: 61339
		public int catID;

		// Token: 0x0400EF9C RID: 61340
		public int ID;

		// Token: 0x0400EF9D RID: 61341
		public string Name;

		// Token: 0x0400EF9E RID: 61342
		public int Max;

		// Token: 0x0400EF9F RID: 61343
		public int Bean;

		// Token: 0x0400EFA0 RID: 61344
		public int Hide;

		// Token: 0x0400EFA1 RID: 61345
		public int isSpecial;

		// Token: 0x0400EFA2 RID: 61346
		public int purpose;

		// Token: 0x0400EFA3 RID: 61347
		public int Sort;

		// Token: 0x0400EFA4 RID: 61348
		public float speed;

		// Token: 0x0400EFA5 RID: 61349
		public string type;

		// Token: 0x0400EFA6 RID: 61350
		public int UseMax;

		// Token: 0x0400EFA7 RID: 61351
		public int VipOnly;

		// Token: 0x0400EFA8 RID: 61352
		public int wd;
	}
}
