using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems27
{
	// Token: 0x02002A3B RID: 10811
	public class IItemsItem : ItemData
	{
		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x06015D72 RID: 89458 RVA: 0x0058E1B8 File Offset: 0x0058C3B8
		// (set) Token: 0x06015D73 RID: 89459 RVA: 0x0058E1C0 File Offset: 0x0058C3C0
		public string Name { get; set; }

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x06015D74 RID: 89460 RVA: 0x0058E1C9 File Offset: 0x0058C3C9
		// (set) Token: 0x06015D75 RID: 89461 RVA: 0x0058E1D1 File Offset: 0x0058C3D1
		public int Bean { get; set; }

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x06015D76 RID: 89462 RVA: 0x0058E1DA File Offset: 0x0058C3DA
		// (set) Token: 0x06015D77 RID: 89463 RVA: 0x0058E1E2 File Offset: 0x0058C3E2
		public int catID { get; set; }

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x06015D78 RID: 89464 RVA: 0x0058E1EB File Offset: 0x0058C3EB
		// (set) Token: 0x06015D79 RID: 89465 RVA: 0x0058E1F3 File Offset: 0x0058C3F3
		public int Hide { get; set; }

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x06015D7A RID: 89466 RVA: 0x0058E1FC File Offset: 0x0058C3FC
		// (set) Token: 0x06015D7B RID: 89467 RVA: 0x0058E204 File Offset: 0x0058C404
		public int ID { get; set; }

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x06015D7C RID: 89468 RVA: 0x0058E20D File Offset: 0x0058C40D
		// (set) Token: 0x06015D7D RID: 89469 RVA: 0x0058E215 File Offset: 0x0058C415
		public int IsMidle { get; set; }

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x06015D7E RID: 89470 RVA: 0x0058E21E File Offset: 0x0058C41E
		// (set) Token: 0x06015D7F RID: 89471 RVA: 0x0058E226 File Offset: 0x0058C426
		public int Max { get; set; }

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x06015D80 RID: 89472 RVA: 0x0058E22F File Offset: 0x0058C42F
		// (set) Token: 0x06015D81 RID: 89473 RVA: 0x0058E237 File Offset: 0x0058C437
		public int purpose { get; set; }

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x06015D82 RID: 89474 RVA: 0x0058E240 File Offset: 0x0058C440
		// (set) Token: 0x06015D83 RID: 89475 RVA: 0x0058E248 File Offset: 0x0058C448
		public int Sort { get; set; }

		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x06015D84 RID: 89476 RVA: 0x0058E251 File Offset: 0x0058C451
		// (set) Token: 0x06015D85 RID: 89477 RVA: 0x0058E259 File Offset: 0x0058C459
		public int Tradability { get; set; }

		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x06015D86 RID: 89478 RVA: 0x0058E262 File Offset: 0x0058C462
		// (set) Token: 0x06015D87 RID: 89479 RVA: 0x0058E26A File Offset: 0x0058C46A
		public int VipTradability { get; set; }

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x06015D88 RID: 89480 RVA: 0x0058E273 File Offset: 0x0058C473
		// (set) Token: 0x06015D89 RID: 89481 RVA: 0x0058E27B File Offset: 0x0058C47B
		public int wd { get; set; }

		// Token: 0x06015D8A RID: 89482 RVA: 0x0058E284 File Offset: 0x0058C484
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.IsMidle = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Tradability = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipTradability = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x06015D8B RID: 89483 RVA: 0x0058E334 File Offset: 0x0058C534
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x06015D8C RID: 89484 RVA: 0x0058E33C File Offset: 0x0058C53C
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x06015D8D RID: 89485 RVA: 0x0058E344 File Offset: 0x0058C544
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x06015D8E RID: 89486 RVA: 0x0058E34C File Offset: 0x0058C54C
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x06015D8F RID: 89487 RVA: 0x0058E354 File Offset: 0x0058C554
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x06015D90 RID: 89488 RVA: 0x0058E35C File Offset: 0x0058C55C
		public override bool IsHide()
		{
			return this.Hide == 1;
		}

		// Token: 0x06015D91 RID: 89489 RVA: 0x0058E367 File Offset: 0x0058C567
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x06015D92 RID: 89490 RVA: 0x0058E36F File Offset: 0x0058C56F
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x06015D93 RID: 89491 RVA: 0x0058E377 File Offset: 0x0058C577
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x06015D94 RID: 89492 RVA: 0x0058E37F File Offset: 0x0058C57F
		public override int GetIsMidle()
		{
			return this.IsMidle;
		}

		// Token: 0x06015D95 RID: 89493 RVA: 0x0058E387 File Offset: 0x0058C587
		public override int GetTradability()
		{
			return this.Tradability;
		}

		// Token: 0x06015D96 RID: 89494 RVA: 0x0058E38F File Offset: 0x0058C58F
		public override int GetVipTradability()
		{
			return this.VipTradability;
		}
	}
}
