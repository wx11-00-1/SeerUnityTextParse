using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems13
{
	// Token: 0x0200200F RID: 8207
	public class IItemsItem : ItemData
	{
		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x0600F8BC RID: 63676 RVA: 0x003FE18C File Offset: 0x003FC38C
		// (set) Token: 0x0600F8BD RID: 63677 RVA: 0x003FE194 File Offset: 0x003FC394
		public string Name { get; set; }

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x0600F8BE RID: 63678 RVA: 0x003FE19D File Offset: 0x003FC39D
		// (set) Token: 0x0600F8BF RID: 63679 RVA: 0x003FE1A5 File Offset: 0x003FC3A5
		public string type { get; set; }

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x0600F8C0 RID: 63680 RVA: 0x003FE1AE File Offset: 0x003FC3AE
		// (set) Token: 0x0600F8C1 RID: 63681 RVA: 0x003FE1B6 File Offset: 0x003FC3B6
		public int Bean { get; set; }

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x0600F8C2 RID: 63682 RVA: 0x003FE1BF File Offset: 0x003FC3BF
		// (set) Token: 0x0600F8C3 RID: 63683 RVA: 0x003FE1C7 File Offset: 0x003FC3C7
		public int catID { get; set; }

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x0600F8C4 RID: 63684 RVA: 0x003FE1D0 File Offset: 0x003FC3D0
		// (set) Token: 0x0600F8C5 RID: 63685 RVA: 0x003FE1D8 File Offset: 0x003FC3D8
		public int Hide { get; set; }

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x0600F8C6 RID: 63686 RVA: 0x003FE1E1 File Offset: 0x003FC3E1
		// (set) Token: 0x0600F8C7 RID: 63687 RVA: 0x003FE1E9 File Offset: 0x003FC3E9
		public int ID { get; set; }

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x0600F8C8 RID: 63688 RVA: 0x003FE1F2 File Offset: 0x003FC3F2
		// (set) Token: 0x0600F8C9 RID: 63689 RVA: 0x003FE1FA File Offset: 0x003FC3FA
		public int isSpecial { get; set; }

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x0600F8CA RID: 63690 RVA: 0x003FE203 File Offset: 0x003FC403
		// (set) Token: 0x0600F8CB RID: 63691 RVA: 0x003FE20B File Offset: 0x003FC40B
		public int Max { get; set; }

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x0600F8CC RID: 63692 RVA: 0x003FE214 File Offset: 0x003FC414
		// (set) Token: 0x0600F8CD RID: 63693 RVA: 0x003FE21C File Offset: 0x003FC41C
		public int purpose { get; set; }

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x0600F8CE RID: 63694 RVA: 0x003FE225 File Offset: 0x003FC425
		// (set) Token: 0x0600F8CF RID: 63695 RVA: 0x003FE22D File Offset: 0x003FC42D
		public int Sort { get; set; }

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x0600F8D0 RID: 63696 RVA: 0x003FE236 File Offset: 0x003FC436
		// (set) Token: 0x0600F8D1 RID: 63697 RVA: 0x003FE23E File Offset: 0x003FC43E
		public float speed { get; set; }

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x0600F8D2 RID: 63698 RVA: 0x003FE247 File Offset: 0x003FC447
		// (set) Token: 0x0600F8D3 RID: 63699 RVA: 0x003FE24F File Offset: 0x003FC44F
		public int UseMax { get; set; }

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x0600F8D4 RID: 63700 RVA: 0x003FE258 File Offset: 0x003FC458
		// (set) Token: 0x0600F8D5 RID: 63701 RVA: 0x003FE260 File Offset: 0x003FC460
		public int VipOnly { get; set; }

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x0600F8D6 RID: 63702 RVA: 0x003FE269 File Offset: 0x003FC469
		// (set) Token: 0x0600F8D7 RID: 63703 RVA: 0x003FE271 File Offset: 0x003FC471
		public int wd { get; set; }

		// Token: 0x0600F8D8 RID: 63704 RVA: 0x003FE27C File Offset: 0x003FC47C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isSpecial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.speed = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F8D9 RID: 63705 RVA: 0x003FE34D File Offset: 0x003FC54D
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F8DA RID: 63706 RVA: 0x003FE355 File Offset: 0x003FC555
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F8DB RID: 63707 RVA: 0x003FE35D File Offset: 0x003FC55D
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F8DC RID: 63708 RVA: 0x003FE365 File Offset: 0x003FC565
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F8DD RID: 63709 RVA: 0x003FE36D File Offset: 0x003FC56D
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F8DE RID: 63710 RVA: 0x003FE375 File Offset: 0x003FC575
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F8DF RID: 63711 RVA: 0x003FE380 File Offset: 0x003FC580
		public override bool IsSpecial()
		{
			return this.isSpecial != 0;
		}

		// Token: 0x0600F8E0 RID: 63712 RVA: 0x003FE38B File Offset: 0x003FC58B
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F8E1 RID: 63713 RVA: 0x003FE393 File Offset: 0x003FC593
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F8E2 RID: 63714 RVA: 0x003FE39B File Offset: 0x003FC59B
		public override float Getspeed()
		{
			return this.speed;
		}

		// Token: 0x0600F8E3 RID: 63715 RVA: 0x003FE3A3 File Offset: 0x003FC5A3
		public override string Gettype()
		{
			return this.type;
		}

		// Token: 0x0600F8E4 RID: 63716 RVA: 0x003FE3AB File Offset: 0x003FC5AB
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x0600F8E5 RID: 63717 RVA: 0x003FE3B3 File Offset: 0x003FC5B3
		public override bool IsSuper()
		{
			return this.VipOnly != 0;
		}

		// Token: 0x0600F8E6 RID: 63718 RVA: 0x003FE3BE File Offset: 0x003FC5BE
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
