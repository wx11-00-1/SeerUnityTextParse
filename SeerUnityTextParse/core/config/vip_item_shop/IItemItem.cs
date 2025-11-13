using System;

namespace core.config.vip_item_shop
{
	// Token: 0x02001EFD RID: 7933
	public class IItemItem
	{
		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x0600ED88 RID: 60808 RVA: 0x003F15D0 File Offset: 0x003EF7D0
		// (set) Token: 0x0600ED89 RID: 60809 RVA: 0x003F15D8 File Offset: 0x003EF7D8
		public int ex { get; set; }

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x0600ED8A RID: 60810 RVA: 0x003F15E1 File Offset: 0x003EF7E1
		// (set) Token: 0x0600ED8B RID: 60811 RVA: 0x003F15E9 File Offset: 0x003EF7E9
		public int Id { get; set; }

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x0600ED8C RID: 60812 RVA: 0x003F15F2 File Offset: 0x003EF7F2
		// (set) Token: 0x0600ED8D RID: 60813 RVA: 0x003F15FA File Offset: 0x003EF7FA
		public int LimitLv { get; set; }

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x0600ED8E RID: 60814 RVA: 0x003F1603 File Offset: 0x003EF803
		// (set) Token: 0x0600ED8F RID: 60815 RVA: 0x003F160B File Offset: 0x003EF80B
		public int LimitNum { get; set; }

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x0600ED90 RID: 60816 RVA: 0x003F1614 File Offset: 0x003EF814
		// (set) Token: 0x0600ED91 RID: 60817 RVA: 0x003F161C File Offset: 0x003EF81C
		public int MiditemId { get; set; }

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x0600ED92 RID: 60818 RVA: 0x003F1625 File Offset: 0x003EF825
		// (set) Token: 0x0600ED93 RID: 60819 RVA: 0x003F162D File Offset: 0x003EF82D
		public int MonthKey { get; set; }

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x0600ED94 RID: 60820 RVA: 0x003F1636 File Offset: 0x003EF836
		// (set) Token: 0x0600ED95 RID: 60821 RVA: 0x003F163E File Offset: 0x003EF83E
		public int MonthPos { get; set; }

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x0600ED96 RID: 60822 RVA: 0x003F1647 File Offset: 0x003EF847
		// (set) Token: 0x0600ED97 RID: 60823 RVA: 0x003F164F File Offset: 0x003EF84F
		public int Price { get; set; }

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x0600ED98 RID: 60824 RVA: 0x003F1658 File Offset: 0x003EF858
		// (set) Token: 0x0600ED99 RID: 60825 RVA: 0x003F1660 File Offset: 0x003EF860
		public int productID { get; set; }

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x0600ED9A RID: 60826 RVA: 0x003F1669 File Offset: 0x003EF869
		// (set) Token: 0x0600ED9B RID: 60827 RVA: 0x003F1671 File Offset: 0x003EF871
		public int ShowNum { get; set; }

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x0600ED9C RID: 60828 RVA: 0x003F167A File Offset: 0x003EF87A
		// (set) Token: 0x0600ED9D RID: 60829 RVA: 0x003F1682 File Offset: 0x003EF882
		public int ShowReward { get; set; }

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x0600ED9E RID: 60830 RVA: 0x003F168B File Offset: 0x003EF88B
		// (set) Token: 0x0600ED9F RID: 60831 RVA: 0x003F1693 File Offset: 0x003EF893
		public int Type { get; set; }

		// Token: 0x0600EDA0 RID: 60832 RVA: 0x003F169C File Offset: 0x003EF89C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LimitLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LimitNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MiditemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonthKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonthPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ShowNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ShowReward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ex = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
