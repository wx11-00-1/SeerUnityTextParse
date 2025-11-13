using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems11
{
	// Token: 0x02002013 RID: 8211
	public class IItemsItem : ItemData
	{
		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x0600F918 RID: 63768 RVA: 0x003FE6B0 File Offset: 0x003FC8B0
		// (set) Token: 0x0600F919 RID: 63769 RVA: 0x003FE6B8 File Offset: 0x003FC8B8
		public string Name { get; set; }

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x0600F91A RID: 63770 RVA: 0x003FE6C1 File Offset: 0x003FC8C1
		// (set) Token: 0x0600F91B RID: 63771 RVA: 0x003FE6C9 File Offset: 0x003FC8C9
		public int Bean { get; set; }

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x0600F91C RID: 63772 RVA: 0x003FE6D2 File Offset: 0x003FC8D2
		// (set) Token: 0x0600F91D RID: 63773 RVA: 0x003FE6DA File Offset: 0x003FC8DA
		public int catID { get; set; }

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x0600F91E RID: 63774 RVA: 0x003FE6E3 File Offset: 0x003FC8E3
		// (set) Token: 0x0600F91F RID: 63775 RVA: 0x003FE6EB File Offset: 0x003FC8EB
		public int ID { get; set; }

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x0600F920 RID: 63776 RVA: 0x003FE6F4 File Offset: 0x003FC8F4
		// (set) Token: 0x0600F921 RID: 63777 RVA: 0x003FE6FC File Offset: 0x003FC8FC
		public int Max { get; set; }

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x0600F922 RID: 63778 RVA: 0x003FE705 File Offset: 0x003FC905
		// (set) Token: 0x0600F923 RID: 63779 RVA: 0x003FE70D File Offset: 0x003FC90D
		public int NeedLv { get; set; }

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x0600F924 RID: 63780 RVA: 0x003FE716 File Offset: 0x003FC916
		// (set) Token: 0x0600F925 RID: 63781 RVA: 0x003FE71E File Offset: 0x003FC91E
		public int purpose { get; set; }

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x0600F926 RID: 63782 RVA: 0x003FE727 File Offset: 0x003FC927
		// (set) Token: 0x0600F927 RID: 63783 RVA: 0x003FE72F File Offset: 0x003FC92F
		public int Rank { get; set; }

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x0600F928 RID: 63784 RVA: 0x003FE738 File Offset: 0x003FC938
		// (set) Token: 0x0600F929 RID: 63785 RVA: 0x003FE740 File Offset: 0x003FC940
		public int Rarity { get; set; }

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x0600F92A RID: 63786 RVA: 0x003FE749 File Offset: 0x003FC949
		// (set) Token: 0x0600F92B RID: 63787 RVA: 0x003FE751 File Offset: 0x003FC951
		public int Sort { get; set; }

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x0600F92C RID: 63788 RVA: 0x003FE75A File Offset: 0x003FC95A
		// (set) Token: 0x0600F92D RID: 63789 RVA: 0x003FE762 File Offset: 0x003FC962
		public int Type { get; set; }

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x0600F92E RID: 63790 RVA: 0x003FE76B File Offset: 0x003FC96B
		// (set) Token: 0x0600F92F RID: 63791 RVA: 0x003FE773 File Offset: 0x003FC973
		public int wd { get; set; }

		// Token: 0x0600F930 RID: 63792 RVA: 0x003FE77C File Offset: 0x003FC97C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.NeedLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rank = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F931 RID: 63793 RVA: 0x003FE82C File Offset: 0x003FCA2C
		public override int GetSelfType()
		{
			return this.Type;
		}

		// Token: 0x0600F932 RID: 63794 RVA: 0x003FE834 File Offset: 0x003FCA34
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F933 RID: 63795 RVA: 0x003FE83C File Offset: 0x003FCA3C
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F934 RID: 63796 RVA: 0x003FE844 File Offset: 0x003FCA44
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F935 RID: 63797 RVA: 0x003FE84C File Offset: 0x003FCA4C
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F936 RID: 63798 RVA: 0x003FE854 File Offset: 0x003FCA54
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0600F937 RID: 63799 RVA: 0x003FE85C File Offset: 0x003FCA5C
		public override int GetNeedLv()
		{
			return this.NeedLv;
		}

		// Token: 0x0600F938 RID: 63800 RVA: 0x003FE864 File Offset: 0x003FCA64
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F939 RID: 63801 RVA: 0x003FE86C File Offset: 0x003FCA6C
		public override int GetRank()
		{
			return this.Rank;
		}

		// Token: 0x0600F93A RID: 63802 RVA: 0x003FE874 File Offset: 0x003FCA74
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600F93B RID: 63803 RVA: 0x003FE87C File Offset: 0x003FCA7C
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F93C RID: 63804 RVA: 0x003FE884 File Offset: 0x003FCA84
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
