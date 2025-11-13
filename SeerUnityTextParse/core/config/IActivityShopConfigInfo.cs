using System;

namespace core.config
{
	// Token: 0x02001C8E RID: 7310
	public class IActivityShopConfigInfo : IConfigItem
	{
		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x0600D364 RID: 54116 RVA: 0x003C9524 File Offset: 0x003C7724
		// (set) Token: 0x0600D365 RID: 54117 RVA: 0x003C952C File Offset: 0x003C772C
		public string commodity { get; set; }

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x0600D366 RID: 54118 RVA: 0x003C9535 File Offset: 0x003C7735
		// (set) Token: 0x0600D367 RID: 54119 RVA: 0x003C953D File Offset: 0x003C773D
		public string shoptype { get; set; }

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x0600D368 RID: 54120 RVA: 0x003C9546 File Offset: 0x003C7746
		// (set) Token: 0x0600D369 RID: 54121 RVA: 0x003C954E File Offset: 0x003C774E
		public long timeend { get; set; }

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x0600D36A RID: 54122 RVA: 0x003C9557 File Offset: 0x003C7757
		// (set) Token: 0x0600D36B RID: 54123 RVA: 0x003C955F File Offset: 0x003C775F
		public int activityid { get; set; }

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x0600D36C RID: 54124 RVA: 0x003C9568 File Offset: 0x003C7768
		// (set) Token: 0x0600D36D RID: 54125 RVA: 0x003C9570 File Offset: 0x003C7770
		public int consumeitemid { get; set; }

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x0600D36E RID: 54126 RVA: 0x003C9579 File Offset: 0x003C7779
		// (set) Token: 0x0600D36F RID: 54127 RVA: 0x003C9581 File Offset: 0x003C7781
		public int exchangeID { get; set; }

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x0600D370 RID: 54128 RVA: 0x003C958A File Offset: 0x003C778A
		// (set) Token: 0x0600D371 RID: 54129 RVA: 0x003C9592 File Offset: 0x003C7792
		public int id { get; set; }

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x0600D372 RID: 54130 RVA: 0x003C959B File Offset: 0x003C779B
		// (set) Token: 0x0600D373 RID: 54131 RVA: 0x003C95A3 File Offset: 0x003C77A3
		public int limit { get; set; }

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x0600D374 RID: 54132 RVA: 0x003C95AC File Offset: 0x003C77AC
		// (set) Token: 0x0600D375 RID: 54133 RVA: 0x003C95B4 File Offset: 0x003C77B4
		public int price { get; set; }

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x0600D376 RID: 54134 RVA: 0x003C95BD File Offset: 0x003C77BD
		// (set) Token: 0x0600D377 RID: 54135 RVA: 0x003C95C5 File Offset: 0x003C77C5
		public int quantity { get; set; }

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x0600D378 RID: 54136 RVA: 0x003C95CE File Offset: 0x003C77CE
		// (set) Token: 0x0600D379 RID: 54137 RVA: 0x003C95D6 File Offset: 0x003C77D6
		public int sort { get; set; }

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x0600D37A RID: 54138 RVA: 0x003C95DF File Offset: 0x003C77DF
		// (set) Token: 0x0600D37B RID: 54139 RVA: 0x003C95E7 File Offset: 0x003C77E7
		public int timelimit { get; set; }

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x0600D37C RID: 54140 RVA: 0x003C95F0 File Offset: 0x003C77F0
		// (set) Token: 0x0600D37D RID: 54141 RVA: 0x003C95F8 File Offset: 0x003C77F8
		public int timestart { get; set; }

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x0600D37E RID: 54142 RVA: 0x003C9601 File Offset: 0x003C7801
		// (set) Token: 0x0600D37F RID: 54143 RVA: 0x003C9609 File Offset: 0x003C7809
		public int userinfo { get; set; }

		// Token: 0x0600D380 RID: 54144 RVA: 0x003C9614 File Offset: 0x003C7814
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.activityid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exchangeID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.shoptype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.timeend = ByteUtil.ReadLong(bytes, ref byteIndex);
			this.timelimit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.timestart = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
