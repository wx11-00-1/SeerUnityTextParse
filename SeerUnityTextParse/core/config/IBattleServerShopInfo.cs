using System;

namespace core.config
{
	// Token: 0x02001CC2 RID: 7362
	public class IBattleServerShopInfo : IConfigItem
	{
		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x0600D59A RID: 54682 RVA: 0x003CBE84 File Offset: 0x003CA084
		// (set) Token: 0x0600D59B RID: 54683 RVA: 0x003CBE8C File Offset: 0x003CA08C
		public int coinid { get; set; }

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x0600D59C RID: 54684 RVA: 0x003CBE95 File Offset: 0x003CA095
		// (set) Token: 0x0600D59D RID: 54685 RVA: 0x003CBE9D File Offset: 0x003CA09D
		public int cointype { get; set; }

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x0600D59E RID: 54686 RVA: 0x003CBEA6 File Offset: 0x003CA0A6
		// (set) Token: 0x0600D59F RID: 54687 RVA: 0x003CBEAE File Offset: 0x003CA0AE
		public int count { get; set; }

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x0600D5A0 RID: 54688 RVA: 0x003CBEB7 File Offset: 0x003CA0B7
		// (set) Token: 0x0600D5A1 RID: 54689 RVA: 0x003CBEBF File Offset: 0x003CA0BF
		public int id { get; set; }

		// Token: 0x170012A1 RID: 4769
		// (get) Token: 0x0600D5A2 RID: 54690 RVA: 0x003CBEC8 File Offset: 0x003CA0C8
		// (set) Token: 0x0600D5A3 RID: 54691 RVA: 0x003CBED0 File Offset: 0x003CA0D0
		public int Limitcount { get; set; }

		// Token: 0x170012A2 RID: 4770
		// (get) Token: 0x0600D5A4 RID: 54692 RVA: 0x003CBED9 File Offset: 0x003CA0D9
		// (set) Token: 0x0600D5A5 RID: 54693 RVA: 0x003CBEE1 File Offset: 0x003CA0E1
		public int Limittype { get; set; }

		// Token: 0x170012A3 RID: 4771
		// (get) Token: 0x0600D5A6 RID: 54694 RVA: 0x003CBEEA File Offset: 0x003CA0EA
		// (set) Token: 0x0600D5A7 RID: 54695 RVA: 0x003CBEF2 File Offset: 0x003CA0F2
		public int price { get; set; }

		// Token: 0x170012A4 RID: 4772
		// (get) Token: 0x0600D5A8 RID: 54696 RVA: 0x003CBEFB File Offset: 0x003CA0FB
		// (set) Token: 0x0600D5A9 RID: 54697 RVA: 0x003CBF03 File Offset: 0x003CA103
		public int realid { get; set; }

		// Token: 0x170012A5 RID: 4773
		// (get) Token: 0x0600D5AA RID: 54698 RVA: 0x003CBF0C File Offset: 0x003CA10C
		// (set) Token: 0x0600D5AB RID: 54699 RVA: 0x003CBF14 File Offset: 0x003CA114
		public int Subtag { get; set; }

		// Token: 0x170012A6 RID: 4774
		// (get) Token: 0x0600D5AC RID: 54700 RVA: 0x003CBF1D File Offset: 0x003CA11D
		// (set) Token: 0x0600D5AD RID: 54701 RVA: 0x003CBF25 File Offset: 0x003CA125
		public int type { get; set; }

		// Token: 0x0600D5AE RID: 54702 RVA: 0x003CBF30 File Offset: 0x003CA130
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Limitcount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Limittype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Subtag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.coinid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.cointype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.count = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.realid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
