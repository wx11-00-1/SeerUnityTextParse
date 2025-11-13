using System;

namespace core.config.vip_pet_shop
{
	// Token: 0x02001EF7 RID: 7927
	public class IPetItem
	{
		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x0600ED46 RID: 60742 RVA: 0x003F1112 File Offset: 0x003EF312
		// (set) Token: 0x0600ED47 RID: 60743 RVA: 0x003F111A File Offset: 0x003EF31A
		public int ForeverHalfPos { get; set; }

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x0600ED48 RID: 60744 RVA: 0x003F1123 File Offset: 0x003EF323
		// (set) Token: 0x0600ED49 RID: 60745 RVA: 0x003F112B File Offset: 0x003EF32B
		public int ForeverKey { get; set; }

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x0600ED4A RID: 60746 RVA: 0x003F1134 File Offset: 0x003EF334
		// (set) Token: 0x0600ED4B RID: 60747 RVA: 0x003F113C File Offset: 0x003EF33C
		public int IsExtra { get; set; }

		// Token: 0x17001ADE RID: 6878
		// (get) Token: 0x0600ED4C RID: 60748 RVA: 0x003F1145 File Offset: 0x003EF345
		// (set) Token: 0x0600ED4D RID: 60749 RVA: 0x003F114D File Offset: 0x003EF34D
		public int JudgeType { get; set; }

		// Token: 0x17001ADF RID: 6879
		// (get) Token: 0x0600ED4E RID: 60750 RVA: 0x003F1156 File Offset: 0x003EF356
		// (set) Token: 0x0600ED4F RID: 60751 RVA: 0x003F115E File Offset: 0x003EF35E
		public int LimitLv { get; set; }

		// Token: 0x17001AE0 RID: 6880
		// (get) Token: 0x0600ED50 RID: 60752 RVA: 0x003F1167 File Offset: 0x003EF367
		// (set) Token: 0x0600ED51 RID: 60753 RVA: 0x003F116F File Offset: 0x003EF36F
		public int MiditemId { get; set; }

		// Token: 0x17001AE1 RID: 6881
		// (get) Token: 0x0600ED52 RID: 60754 RVA: 0x003F1178 File Offset: 0x003EF378
		// (set) Token: 0x0600ED53 RID: 60755 RVA: 0x003F1180 File Offset: 0x003EF380
		public int MintmarkId { get; set; }

		// Token: 0x17001AE2 RID: 6882
		// (get) Token: 0x0600ED54 RID: 60756 RVA: 0x003F1189 File Offset: 0x003EF389
		// (set) Token: 0x0600ED55 RID: 60757 RVA: 0x003F1191 File Offset: 0x003EF391
		public int NewSe { get; set; }

		// Token: 0x17001AE3 RID: 6883
		// (get) Token: 0x0600ED56 RID: 60758 RVA: 0x003F119A File Offset: 0x003EF39A
		// (set) Token: 0x0600ED57 RID: 60759 RVA: 0x003F11A2 File Offset: 0x003EF3A2
		public int PetId { get; set; }

		// Token: 0x17001AE4 RID: 6884
		// (get) Token: 0x0600ED58 RID: 60760 RVA: 0x003F11AB File Offset: 0x003EF3AB
		// (set) Token: 0x0600ED59 RID: 60761 RVA: 0x003F11B3 File Offset: 0x003EF3B3
		public int Price { get; set; }

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x0600ED5A RID: 60762 RVA: 0x003F11BC File Offset: 0x003EF3BC
		// (set) Token: 0x0600ED5B RID: 60763 RVA: 0x003F11C4 File Offset: 0x003EF3C4
		public int productID { get; set; }

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x0600ED5C RID: 60764 RVA: 0x003F11CD File Offset: 0x003EF3CD
		// (set) Token: 0x0600ED5D RID: 60765 RVA: 0x003F11D5 File Offset: 0x003EF3D5
		public int TimeId { get; set; }

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x0600ED5E RID: 60766 RVA: 0x003F11DE File Offset: 0x003EF3DE
		// (set) Token: 0x0600ED5F RID: 60767 RVA: 0x003F11E6 File Offset: 0x003EF3E6
		public int TimeSubId { get; set; }

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x0600ED60 RID: 60768 RVA: 0x003F11EF File Offset: 0x003EF3EF
		// (set) Token: 0x0600ED61 RID: 60769 RVA: 0x003F11F7 File Offset: 0x003EF3F7
		public int Turn { get; set; }

		// Token: 0x0600ED62 RID: 60770 RVA: 0x003F1200 File Offset: 0x003EF400
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ForeverHalfPos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ForeverKey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.IsExtra = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.JudgeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LimitLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MiditemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MintmarkId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewSe = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TimeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TimeSubId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Turn = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.productID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
