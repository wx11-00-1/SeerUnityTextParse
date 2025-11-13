using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001ED7 RID: 7895
	public class itemsOptimizeCatItem10Def : ItemData
	{
		// Token: 0x0600EC15 RID: 60437 RVA: 0x003EFA3E File Offset: 0x003EDC3E
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600EC16 RID: 60438 RVA: 0x003EFA46 File Offset: 0x003EDC46
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600EC17 RID: 60439 RVA: 0x003EFA4E File Offset: 0x003EDC4E
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600EC18 RID: 60440 RVA: 0x003EFA56 File Offset: 0x003EDC56
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600EC19 RID: 60441 RVA: 0x003EFA5E File Offset: 0x003EDC5E
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600EC1A RID: 60442 RVA: 0x003EFA66 File Offset: 0x003EDC66
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600EC1B RID: 60443 RVA: 0x003EFA71 File Offset: 0x003EDC71
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600EC1C RID: 60444 RVA: 0x003EFA79 File Offset: 0x003EDC79
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600EC1D RID: 60445 RVA: 0x003EFA81 File Offset: 0x003EDC81
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600EC1E RID: 60446 RVA: 0x003EFA89 File Offset: 0x003EDC89
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0600EC1F RID: 60447 RVA: 0x003EFA94 File Offset: 0x003EDC94
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF79 RID: 61305
		public int catID;

		// Token: 0x0400EF7A RID: 61306
		public int ID;

		// Token: 0x0400EF7B RID: 61307
		public string Name;

		// Token: 0x0400EF7C RID: 61308
		public int Max;

		// Token: 0x0400EF7D RID: 61309
		public int Bean;

		// Token: 0x0400EF7E RID: 61310
		public int Hide;

		// Token: 0x0400EF7F RID: 61311
		public int purpose;

		// Token: 0x0400EF80 RID: 61312
		public int Sort;

		// Token: 0x0400EF81 RID: 61313
		public int UseMax;

		// Token: 0x0400EF82 RID: 61314
		public int wd;
	}
}
