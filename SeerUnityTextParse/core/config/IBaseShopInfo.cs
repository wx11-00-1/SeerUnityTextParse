using System;

namespace core.config
{
	// Token: 0x02001CBA RID: 7354
	public class IBaseShopInfo : IConfigItem
	{
		// Token: 0x1700127B RID: 4731
		// (get) Token: 0x0600D546 RID: 54598 RVA: 0x003CB870 File Offset: 0x003C9A70
		// (set) Token: 0x0600D547 RID: 54599 RVA: 0x003CB878 File Offset: 0x003C9A78
		public string cost { get; set; }

		// Token: 0x1700127C RID: 4732
		// (get) Token: 0x0600D548 RID: 54600 RVA: 0x003CB881 File Offset: 0x003C9A81
		// (set) Token: 0x0600D549 RID: 54601 RVA: 0x003CB889 File Offset: 0x003C9A89
		public string name { get; set; }

		// Token: 0x1700127D RID: 4733
		// (get) Token: 0x0600D54A RID: 54602 RVA: 0x003CB892 File Offset: 0x003C9A92
		// (set) Token: 0x0600D54B RID: 54603 RVA: 0x003CB89A File Offset: 0x003C9A9A
		public int id { get; set; }

		// Token: 0x1700127E RID: 4734
		// (get) Token: 0x0600D54C RID: 54604 RVA: 0x003CB8A3 File Offset: 0x003C9AA3
		// (set) Token: 0x0600D54D RID: 54605 RVA: 0x003CB8AB File Offset: 0x003C9AAB
		public int max { get; set; }

		// Token: 0x1700127F RID: 4735
		// (get) Token: 0x0600D54E RID: 54606 RVA: 0x003CB8B4 File Offset: 0x003C9AB4
		// (set) Token: 0x0600D54F RID: 54607 RVA: 0x003CB8BC File Offset: 0x003C9ABC
		public int num { get; set; }

		// Token: 0x17001280 RID: 4736
		// (get) Token: 0x0600D550 RID: 54608 RVA: 0x003CB8C5 File Offset: 0x003C9AC5
		// (set) Token: 0x0600D551 RID: 54609 RVA: 0x003CB8CD File Offset: 0x003C9ACD
		public int type { get; set; }

		// Token: 0x17001281 RID: 4737
		// (get) Token: 0x0600D552 RID: 54610 RVA: 0x003CB8D6 File Offset: 0x003C9AD6
		// (set) Token: 0x0600D553 RID: 54611 RVA: 0x003CB8DE File Offset: 0x003C9ADE
		public int vipOnly { get; set; }

		// Token: 0x0600D554 RID: 54612 RVA: 0x003CB8E8 File Offset: 0x003C9AE8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.cost = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.vipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
