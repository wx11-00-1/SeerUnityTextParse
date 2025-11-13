using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems14
{
	// Token: 0x0200200D RID: 8205
	public class IItemsItem : ItemData
	{
		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x0600F896 RID: 63638 RVA: 0x003FDF60 File Offset: 0x003FC160
		// (set) Token: 0x0600F897 RID: 63639 RVA: 0x003FDF68 File Offset: 0x003FC168
		public string Name { get; set; }

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x0600F898 RID: 63640 RVA: 0x003FDF71 File Offset: 0x003FC171
		// (set) Token: 0x0600F899 RID: 63641 RVA: 0x003FDF79 File Offset: 0x003FC179
		public int Bean { get; set; }

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x0600F89A RID: 63642 RVA: 0x003FDF82 File Offset: 0x003FC182
		// (set) Token: 0x0600F89B RID: 63643 RVA: 0x003FDF8A File Offset: 0x003FC18A
		public int catID { get; set; }

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x0600F89C RID: 63644 RVA: 0x003FDF93 File Offset: 0x003FC193
		// (set) Token: 0x0600F89D RID: 63645 RVA: 0x003FDF9B File Offset: 0x003FC19B
		public int Hide { get; set; }

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x0600F89E RID: 63646 RVA: 0x003FDFA4 File Offset: 0x003FC1A4
		// (set) Token: 0x0600F89F RID: 63647 RVA: 0x003FDFAC File Offset: 0x003FC1AC
		public int ID { get; set; }

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x0600F8A0 RID: 63648 RVA: 0x003FDFB5 File Offset: 0x003FC1B5
		// (set) Token: 0x0600F8A1 RID: 63649 RVA: 0x003FDFBD File Offset: 0x003FC1BD
		public int Max { get; set; }

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x0600F8A2 RID: 63650 RVA: 0x003FDFC6 File Offset: 0x003FC1C6
		// (set) Token: 0x0600F8A3 RID: 63651 RVA: 0x003FDFCE File Offset: 0x003FC1CE
		public int purpose { get; set; }

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x0600F8A4 RID: 63652 RVA: 0x003FDFD7 File Offset: 0x003FC1D7
		// (set) Token: 0x0600F8A5 RID: 63653 RVA: 0x003FDFDF File Offset: 0x003FC1DF
		public int Rarity { get; set; }

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x0600F8A6 RID: 63654 RVA: 0x003FDFE8 File Offset: 0x003FC1E8
		// (set) Token: 0x0600F8A7 RID: 63655 RVA: 0x003FDFF0 File Offset: 0x003FC1F0
		public int Sort { get; set; }

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x0600F8A8 RID: 63656 RVA: 0x003FDFF9 File Offset: 0x003FC1F9
		// (set) Token: 0x0600F8A9 RID: 63657 RVA: 0x003FE001 File Offset: 0x003FC201
		public int wd { get; set; }

		// Token: 0x0600F8AA RID: 63658 RVA: 0x003FE00C File Offset: 0x003FC20C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F8AB RID: 63659 RVA: 0x003FE0A2 File Offset: 0x003FC2A2
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F8AC RID: 63660 RVA: 0x003FE0AA File Offset: 0x003FC2AA
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F8AD RID: 63661 RVA: 0x003FE0B2 File Offset: 0x003FC2B2
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F8AE RID: 63662 RVA: 0x003FE0BA File Offset: 0x003FC2BA
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F8AF RID: 63663 RVA: 0x003FE0C2 File Offset: 0x003FC2C2
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F8B0 RID: 63664 RVA: 0x003FE0CA File Offset: 0x003FC2CA
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F8B1 RID: 63665 RVA: 0x003FE0D5 File Offset: 0x003FC2D5
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F8B2 RID: 63666 RVA: 0x003FE0DD File Offset: 0x003FC2DD
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600F8B3 RID: 63667 RVA: 0x003FE0E5 File Offset: 0x003FC2E5
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F8B4 RID: 63668 RVA: 0x003FE0ED File Offset: 0x003FC2ED
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
