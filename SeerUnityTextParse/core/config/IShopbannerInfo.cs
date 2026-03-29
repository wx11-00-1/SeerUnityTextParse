using System;

namespace core.config
{
	// Token: 0x02002359 RID: 9049
	public class IShopbannerInfo : IConfigItem
	{
		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x0601146A RID: 70762 RVA: 0x00499F6C File Offset: 0x0049816C
		// (set) Token: 0x0601146B RID: 70763 RVA: 0x00499F74 File Offset: 0x00498174
		public string endtime { get; set; }

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x0601146C RID: 70764 RVA: 0x00499F7D File Offset: 0x0049817D
		// (set) Token: 0x0601146D RID: 70765 RVA: 0x00499F85 File Offset: 0x00498185
		public string gotoaddress { get; set; }

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x0601146E RID: 70766 RVA: 0x00499F8E File Offset: 0x0049818E
		// (set) Token: 0x0601146F RID: 70767 RVA: 0x00499F96 File Offset: 0x00498196
		public string pic { get; set; }

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06011470 RID: 70768 RVA: 0x00499F9F File Offset: 0x0049819F
		// (set) Token: 0x06011471 RID: 70769 RVA: 0x00499FA7 File Offset: 0x004981A7
		public string starttime { get; set; }

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x06011472 RID: 70770 RVA: 0x00499FB0 File Offset: 0x004981B0
		// (set) Token: 0x06011473 RID: 70771 RVA: 0x00499FB8 File Offset: 0x004981B8
		public int gototype { get; set; }

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06011474 RID: 70772 RVA: 0x00499FC1 File Offset: 0x004981C1
		// (set) Token: 0x06011475 RID: 70773 RVA: 0x00499FC9 File Offset: 0x004981C9
		public int id { get; set; }

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x06011476 RID: 70774 RVA: 0x00499FD2 File Offset: 0x004981D2
		// (set) Token: 0x06011477 RID: 70775 RVA: 0x00499FDA File Offset: 0x004981DA
		public int sequence { get; set; }

		// Token: 0x06011478 RID: 70776 RVA: 0x00499FE4 File Offset: 0x004981E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.gotoaddress = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.gototype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sequence = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
