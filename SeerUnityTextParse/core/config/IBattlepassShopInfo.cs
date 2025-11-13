using System;

namespace core.config
{
	// Token: 0x02001CBE RID: 7358
	public class IBattlepassShopInfo : IConfigItem
	{
		// Token: 0x17001289 RID: 4745
		// (get) Token: 0x0600D56A RID: 54634 RVA: 0x003CBB1C File Offset: 0x003C9D1C
		// (set) Token: 0x0600D56B RID: 54635 RVA: 0x003CBB24 File Offset: 0x003C9D24
		public string commodity { get; set; }

		// Token: 0x1700128A RID: 4746
		// (get) Token: 0x0600D56C RID: 54636 RVA: 0x003CBB2D File Offset: 0x003C9D2D
		// (set) Token: 0x0600D56D RID: 54637 RVA: 0x003CBB35 File Offset: 0x003C9D35
		public int consumeitemid { get; set; }

		// Token: 0x1700128B RID: 4747
		// (get) Token: 0x0600D56E RID: 54638 RVA: 0x003CBB3E File Offset: 0x003C9D3E
		// (set) Token: 0x0600D56F RID: 54639 RVA: 0x003CBB46 File Offset: 0x003C9D46
		public int discount { get; set; }

		// Token: 0x1700128C RID: 4748
		// (get) Token: 0x0600D570 RID: 54640 RVA: 0x003CBB4F File Offset: 0x003C9D4F
		// (set) Token: 0x0600D571 RID: 54641 RVA: 0x003CBB57 File Offset: 0x003C9D57
		public int id { get; set; }

		// Token: 0x1700128D RID: 4749
		// (get) Token: 0x0600D572 RID: 54642 RVA: 0x003CBB60 File Offset: 0x003C9D60
		// (set) Token: 0x0600D573 RID: 54643 RVA: 0x003CBB68 File Offset: 0x003C9D68
		public int limit { get; set; }

		// Token: 0x1700128E RID: 4750
		// (get) Token: 0x0600D574 RID: 54644 RVA: 0x003CBB71 File Offset: 0x003C9D71
		// (set) Token: 0x0600D575 RID: 54645 RVA: 0x003CBB79 File Offset: 0x003C9D79
		public int price { get; set; }

		// Token: 0x1700128F RID: 4751
		// (get) Token: 0x0600D576 RID: 54646 RVA: 0x003CBB82 File Offset: 0x003C9D82
		// (set) Token: 0x0600D577 RID: 54647 RVA: 0x003CBB8A File Offset: 0x003C9D8A
		public int quantity { get; set; }

		// Token: 0x17001290 RID: 4752
		// (get) Token: 0x0600D578 RID: 54648 RVA: 0x003CBB93 File Offset: 0x003C9D93
		// (set) Token: 0x0600D579 RID: 54649 RVA: 0x003CBB9B File Offset: 0x003C9D9B
		public int sort { get; set; }

		// Token: 0x17001291 RID: 4753
		// (get) Token: 0x0600D57A RID: 54650 RVA: 0x003CBBA4 File Offset: 0x003C9DA4
		// (set) Token: 0x0600D57B RID: 54651 RVA: 0x003CBBAC File Offset: 0x003C9DAC
		public int userinfo { get; set; }

		// Token: 0x0600D57C RID: 54652 RVA: 0x003CBBB8 File Offset: 0x003C9DB8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.commodity = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.consumeitemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.discount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limit = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
