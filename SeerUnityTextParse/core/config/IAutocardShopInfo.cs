using System;

namespace core.config
{
	// Token: 0x02002141 RID: 8513
	public class IAutocardShopInfo : IConfigItem
	{
		// Token: 0x17001505 RID: 5381
		// (get) Token: 0x0600FD0C RID: 64780 RVA: 0x0047D968 File Offset: 0x0047BB68
		// (set) Token: 0x0600FD0D RID: 64781 RVA: 0x0047D970 File Offset: 0x0047BB70
		public int bonuscard { get; set; }

		// Token: 0x17001506 RID: 5382
		// (get) Token: 0x0600FD0E RID: 64782 RVA: 0x0047D979 File Offset: 0x0047BB79
		// (set) Token: 0x0600FD0F RID: 64783 RVA: 0x0047D981 File Offset: 0x0047BB81
		public int cardmax { get; set; }

		// Token: 0x17001507 RID: 5383
		// (get) Token: 0x0600FD10 RID: 64784 RVA: 0x0047D98A File Offset: 0x0047BB8A
		// (set) Token: 0x0600FD11 RID: 64785 RVA: 0x0047D992 File Offset: 0x0047BB92
		public int id { get; set; }

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x0600FD12 RID: 64786 RVA: 0x0047D99B File Offset: 0x0047BB9B
		// (set) Token: 0x0600FD13 RID: 64787 RVA: 0x0047D9A3 File Offset: 0x0047BBA3
		public int level { get; set; }

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x0600FD14 RID: 64788 RVA: 0x0047D9AC File Offset: 0x0047BBAC
		// (set) Token: 0x0600FD15 RID: 64789 RVA: 0x0047D9B4 File Offset: 0x0047BBB4
		public int lvlup_cost { get; set; }

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x0600FD16 RID: 64790 RVA: 0x0047D9BD File Offset: 0x0047BBBD
		// (set) Token: 0x0600FD17 RID: 64791 RVA: 0x0047D9C5 File Offset: 0x0047BBC5
		public int rate1 { get; set; }

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x0600FD18 RID: 64792 RVA: 0x0047D9CE File Offset: 0x0047BBCE
		// (set) Token: 0x0600FD19 RID: 64793 RVA: 0x0047D9D6 File Offset: 0x0047BBD6
		public int rate2 { get; set; }

		// Token: 0x1700150C RID: 5388
		// (get) Token: 0x0600FD1A RID: 64794 RVA: 0x0047D9DF File Offset: 0x0047BBDF
		// (set) Token: 0x0600FD1B RID: 64795 RVA: 0x0047D9E7 File Offset: 0x0047BBE7
		public int rate3 { get; set; }

		// Token: 0x1700150D RID: 5389
		// (get) Token: 0x0600FD1C RID: 64796 RVA: 0x0047D9F0 File Offset: 0x0047BBF0
		// (set) Token: 0x0600FD1D RID: 64797 RVA: 0x0047D9F8 File Offset: 0x0047BBF8
		public int rate4 { get; set; }

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x0600FD1E RID: 64798 RVA: 0x0047DA01 File Offset: 0x0047BC01
		// (set) Token: 0x0600FD1F RID: 64799 RVA: 0x0047DA09 File Offset: 0x0047BC09
		public int rate5 { get; set; }

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x0600FD20 RID: 64800 RVA: 0x0047DA12 File Offset: 0x0047BC12
		// (set) Token: 0x0600FD21 RID: 64801 RVA: 0x0047DA1A File Offset: 0x0047BC1A
		public int rate6 { get; set; }

		// Token: 0x0600FD22 RID: 64802 RVA: 0x0047DA24 File Offset: 0x0047BC24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bonuscard = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.cardmax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lvlup_cost = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rate1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rate2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rate3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rate4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rate5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rate6 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
