using System;
using core.config.itemsOptimize;

namespace core.config.itemsOptimizeCatItems12
{
	// Token: 0x02002011 RID: 8209
	public class IItemsItem : ItemData
	{
		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x0600F8EE RID: 63726 RVA: 0x003FE45C File Offset: 0x003FC65C
		// (set) Token: 0x0600F8EF RID: 63727 RVA: 0x003FE464 File Offset: 0x003FC664
		public string Name { get; set; }

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x0600F8F0 RID: 63728 RVA: 0x003FE46D File Offset: 0x003FC66D
		// (set) Token: 0x0600F8F1 RID: 63729 RVA: 0x003FE475 File Offset: 0x003FC675
		public int catID { get; set; }

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x0600F8F2 RID: 63730 RVA: 0x003FE47E File Offset: 0x003FC67E
		// (set) Token: 0x0600F8F3 RID: 63731 RVA: 0x003FE486 File Offset: 0x003FC686
		public int ExchangeId { get; set; }

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x0600F8F4 RID: 63732 RVA: 0x003FE48F File Offset: 0x003FC68F
		// (set) Token: 0x0600F8F5 RID: 63733 RVA: 0x003FE497 File Offset: 0x003FC697
		public int Hide { get; set; }

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x0600F8F6 RID: 63734 RVA: 0x003FE4A0 File Offset: 0x003FC6A0
		// (set) Token: 0x0600F8F7 RID: 63735 RVA: 0x003FE4A8 File Offset: 0x003FC6A8
		public int ID { get; set; }

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x0600F8F8 RID: 63736 RVA: 0x003FE4B1 File Offset: 0x003FC6B1
		// (set) Token: 0x0600F8F9 RID: 63737 RVA: 0x003FE4B9 File Offset: 0x003FC6B9
		public int Max { get; set; }

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x0600F8FA RID: 63738 RVA: 0x003FE4C2 File Offset: 0x003FC6C2
		// (set) Token: 0x0600F8FB RID: 63739 RVA: 0x003FE4CA File Offset: 0x003FC6CA
		public int purpose { get; set; }

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x0600F8FC RID: 63740 RVA: 0x003FE4D3 File Offset: 0x003FC6D3
		// (set) Token: 0x0600F8FD RID: 63741 RVA: 0x003FE4DB File Offset: 0x003FC6DB
		public int Rarity { get; set; }

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x0600F8FE RID: 63742 RVA: 0x003FE4E4 File Offset: 0x003FC6E4
		// (set) Token: 0x0600F8FF RID: 63743 RVA: 0x003FE4EC File Offset: 0x003FC6EC
		public int Sort { get; set; }

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x0600F900 RID: 63744 RVA: 0x003FE4F5 File Offset: 0x003FC6F5
		// (set) Token: 0x0600F901 RID: 63745 RVA: 0x003FE4FD File Offset: 0x003FC6FD
		public int TargetId { get; set; }

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x0600F902 RID: 63746 RVA: 0x003FE506 File Offset: 0x003FC706
		// (set) Token: 0x0600F903 RID: 63747 RVA: 0x003FE50E File Offset: 0x003FC70E
		public int wd { get; set; }

		// Token: 0x0600F904 RID: 63748 RVA: 0x003FE518 File Offset: 0x003FC718
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0600F905 RID: 63749 RVA: 0x003FE5BB File Offset: 0x003FC7BB
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0600F906 RID: 63750 RVA: 0x003FE5C3 File Offset: 0x003FC7C3
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0600F907 RID: 63751 RVA: 0x003FE5CB File Offset: 0x003FC7CB
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0600F908 RID: 63752 RVA: 0x003FE5D3 File Offset: 0x003FC7D3
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0600F909 RID: 63753 RVA: 0x003FE5DB File Offset: 0x003FC7DB
		public override int GetBean()
		{
			return 0;
		}

		// Token: 0x0600F90A RID: 63754 RVA: 0x003FE5DE File Offset: 0x003FC7DE
		public override int GetExchangeId()
		{
			return this.ExchangeId;
		}

		// Token: 0x0600F90B RID: 63755 RVA: 0x003FE5E6 File Offset: 0x003FC7E6
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0600F90C RID: 63756 RVA: 0x003FE5F1 File Offset: 0x003FC7F1
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0600F90D RID: 63757 RVA: 0x003FE5F9 File Offset: 0x003FC7F9
		public override int GetTargetId()
		{
			return this.TargetId;
		}

		// Token: 0x0600F90E RID: 63758 RVA: 0x003FE601 File Offset: 0x003FC801
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0600F90F RID: 63759 RVA: 0x003FE609 File Offset: 0x003FC809
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0600F910 RID: 63760 RVA: 0x003FE611 File Offset: 0x003FC811
		public override int Getwd()
		{
			return this.wd;
		}
	}
}
