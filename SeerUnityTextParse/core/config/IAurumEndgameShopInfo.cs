using System;

namespace core.config
{
	// Token: 0x0200242F RID: 9263
	public class IAurumEndgameShopInfo : IConfigItem
	{
		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06011854 RID: 71764 RVA: 0x005008FC File Offset: 0x004FEAFC
		// (set) Token: 0x06011855 RID: 71765 RVA: 0x00500904 File Offset: 0x004FEB04
		public int endtime { get; set; }

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06011856 RID: 71766 RVA: 0x0050090D File Offset: 0x004FEB0D
		// (set) Token: 0x06011857 RID: 71767 RVA: 0x00500915 File Offset: 0x004FEB15
		public int id { get; set; }

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06011858 RID: 71768 RVA: 0x0050091E File Offset: 0x004FEB1E
		// (set) Token: 0x06011859 RID: 71769 RVA: 0x00500926 File Offset: 0x004FEB26
		public int itemid { get; set; }

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x0601185A RID: 71770 RVA: 0x0050092F File Offset: 0x004FEB2F
		// (set) Token: 0x0601185B RID: 71771 RVA: 0x00500937 File Offset: 0x004FEB37
		public int price { get; set; }

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x0601185C RID: 71772 RVA: 0x00500940 File Offset: 0x004FEB40
		// (set) Token: 0x0601185D RID: 71773 RVA: 0x00500948 File Offset: 0x004FEB48
		public int quantity { get; set; }

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x0601185E RID: 71774 RVA: 0x00500951 File Offset: 0x004FEB51
		// (set) Token: 0x0601185F RID: 71775 RVA: 0x00500959 File Offset: 0x004FEB59
		public int quota { get; set; }

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06011860 RID: 71776 RVA: 0x00500962 File Offset: 0x004FEB62
		// (set) Token: 0x06011861 RID: 71777 RVA: 0x0050096A File Offset: 0x004FEB6A
		public int starttime { get; set; }

		// Token: 0x06011862 RID: 71778 RVA: 0x00500974 File Offset: 0x004FEB74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quota = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
