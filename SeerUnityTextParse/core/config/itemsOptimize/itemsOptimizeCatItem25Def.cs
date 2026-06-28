using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028E2 RID: 10466
	public class itemsOptimizeCatItem25Def : ItemData
	{
		// Token: 0x0601509D RID: 86173 RVA: 0x0057E42C File Offset: 0x0057C62C
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0601509E RID: 86174 RVA: 0x0057E434 File Offset: 0x0057C634
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0601509F RID: 86175 RVA: 0x0057E43C File Offset: 0x0057C63C
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x060150A0 RID: 86176 RVA: 0x0057E444 File Offset: 0x0057C644
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x060150A1 RID: 86177 RVA: 0x0057E44C File Offset: 0x0057C64C
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x060150A2 RID: 86178 RVA: 0x0057E457 File Offset: 0x0057C657
		public override int GetLifeTime()
		{
			return this.LifeTime;
		}

		// Token: 0x060150A3 RID: 86179 RVA: 0x0057E45F File Offset: 0x0057C65F
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x060150A4 RID: 86180 RVA: 0x0057E467 File Offset: 0x0057C667
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x060150A5 RID: 86181 RVA: 0x0057E46F File Offset: 0x0057C66F
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x060150A6 RID: 86182 RVA: 0x0057E477 File Offset: 0x0057C677
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x060150A7 RID: 86183 RVA: 0x0057E480 File Offset: 0x0057C680
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

		// Token: 0x04014024 RID: 81956
		public int catID;

		// Token: 0x04014025 RID: 81957
		public int ID;

		// Token: 0x04014026 RID: 81958
		public string Name;

		// Token: 0x04014027 RID: 81959
		public int Max;

		// Token: 0x04014028 RID: 81960
		public int Hide;

		// Token: 0x04014029 RID: 81961
		public int LifeTime;

		// Token: 0x0401402A RID: 81962
		public int Rarity;

		// Token: 0x0401402B RID: 81963
		public int wd;

		// Token: 0x0401402C RID: 81964
		public int Sort;

		// Token: 0x0401402D RID: 81965
		public int UseMax;
	}
}
