using System;

namespace core.config
{
	// Token: 0x02001D80 RID: 7552
	public class ILlsCookerUpgradeInfo : IConfigItem
	{
		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x0600DD50 RID: 56656 RVA: 0x003D5638 File Offset: 0x003D3838
		// (set) Token: 0x0600DD51 RID: 56657 RVA: 0x003D5640 File Offset: 0x003D3840
		public int id { get; set; }

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x0600DD52 RID: 56658 RVA: 0x003D5649 File Offset: 0x003D3849
		// (set) Token: 0x0600DD53 RID: 56659 RVA: 0x003D5651 File Offset: 0x003D3851
		public int isupgrade { get; set; }

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x0600DD54 RID: 56660 RVA: 0x003D565A File Offset: 0x003D385A
		// (set) Token: 0x0600DD55 RID: 56661 RVA: 0x003D5662 File Offset: 0x003D3862
		public int price1 { get; set; }

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x0600DD56 RID: 56662 RVA: 0x003D566B File Offset: 0x003D386B
		// (set) Token: 0x0600DD57 RID: 56663 RVA: 0x003D5673 File Offset: 0x003D3873
		public int price2 { get; set; }

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x0600DD58 RID: 56664 RVA: 0x003D567C File Offset: 0x003D387C
		// (set) Token: 0x0600DD59 RID: 56665 RVA: 0x003D5684 File Offset: 0x003D3884
		public int price3 { get; set; }

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x0600DD5A RID: 56666 RVA: 0x003D568D File Offset: 0x003D388D
		// (set) Token: 0x0600DD5B RID: 56667 RVA: 0x003D5695 File Offset: 0x003D3895
		public int time1 { get; set; }

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x0600DD5C RID: 56668 RVA: 0x003D569E File Offset: 0x003D389E
		// (set) Token: 0x0600DD5D RID: 56669 RVA: 0x003D56A6 File Offset: 0x003D38A6
		public int time2 { get; set; }

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x0600DD5E RID: 56670 RVA: 0x003D56AF File Offset: 0x003D38AF
		// (set) Token: 0x0600DD5F RID: 56671 RVA: 0x003D56B7 File Offset: 0x003D38B7
		public int time3 { get; set; }

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x0600DD60 RID: 56672 RVA: 0x003D56C0 File Offset: 0x003D38C0
		// (set) Token: 0x0600DD61 RID: 56673 RVA: 0x003D56C8 File Offset: 0x003D38C8
		public int type { get; set; }

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x0600DD62 RID: 56674 RVA: 0x003D56D1 File Offset: 0x003D38D1
		// (set) Token: 0x0600DD63 RID: 56675 RVA: 0x003D56D9 File Offset: 0x003D38D9
		public int unlock { get; set; }

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x0600DD64 RID: 56676 RVA: 0x003D56E2 File Offset: 0x003D38E2
		// (set) Token: 0x0600DD65 RID: 56677 RVA: 0x003D56EA File Offset: 0x003D38EA
		public int upgrade1 { get; set; }

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x0600DD66 RID: 56678 RVA: 0x003D56F3 File Offset: 0x003D38F3
		// (set) Token: 0x0600DD67 RID: 56679 RVA: 0x003D56FB File Offset: 0x003D38FB
		public int upgrade2 { get; set; }

		// Token: 0x0600DD68 RID: 56680 RVA: 0x003D5704 File Offset: 0x003D3904
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isupgrade = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.upgrade1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.upgrade2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
