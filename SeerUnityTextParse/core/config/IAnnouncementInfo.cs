using System;

namespace core.config
{
	// Token: 0x0200211D RID: 8477
	public class IAnnouncementInfo : IConfigItem
	{
		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x0600FB96 RID: 64406 RVA: 0x0047BD68 File Offset: 0x00479F68
		// (set) Token: 0x0600FB97 RID: 64407 RVA: 0x0047BD70 File Offset: 0x00479F70
		public string beginning { get; set; }

		// Token: 0x1700146F RID: 5231
		// (get) Token: 0x0600FB98 RID: 64408 RVA: 0x0047BD79 File Offset: 0x00479F79
		// (set) Token: 0x0600FB99 RID: 64409 RVA: 0x0047BD81 File Offset: 0x00479F81
		public string ending { get; set; }

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x0600FB9A RID: 64410 RVA: 0x0047BD8A File Offset: 0x00479F8A
		// (set) Token: 0x0600FB9B RID: 64411 RVA: 0x0047BD92 File Offset: 0x00479F92
		public string subtitle { get; set; }

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x0600FB9C RID: 64412 RVA: 0x0047BD9B File Offset: 0x00479F9B
		// (set) Token: 0x0600FB9D RID: 64413 RVA: 0x0047BDA3 File Offset: 0x00479FA3
		public string text { get; set; }

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x0600FB9E RID: 64414 RVA: 0x0047BDAC File Offset: 0x00479FAC
		// (set) Token: 0x0600FB9F RID: 64415 RVA: 0x0047BDB4 File Offset: 0x00479FB4
		public string title { get; set; }

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x0600FBA0 RID: 64416 RVA: 0x0047BDBD File Offset: 0x00479FBD
		// (set) Token: 0x0600FBA1 RID: 64417 RVA: 0x0047BDC5 File Offset: 0x00479FC5
		public int id { get; set; }

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x0600FBA2 RID: 64418 RVA: 0x0047BDCE File Offset: 0x00479FCE
		// (set) Token: 0x0600FBA3 RID: 64419 RVA: 0x0047BDD6 File Offset: 0x00479FD6
		public int shouldread { get; set; }

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x0600FBA4 RID: 64420 RVA: 0x0047BDDF File Offset: 0x00479FDF
		// (set) Token: 0x0600FBA5 RID: 64421 RVA: 0x0047BDE7 File Offset: 0x00479FE7
		public int sorting { get; set; }

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x0600FBA6 RID: 64422 RVA: 0x0047BDF0 File Offset: 0x00479FF0
		// (set) Token: 0x0600FBA7 RID: 64423 RVA: 0x0047BDF8 File Offset: 0x00479FF8
		public int type { get; set; }

		// Token: 0x0600FBA8 RID: 64424 RVA: 0x0047BE04 File Offset: 0x0047A004
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.beginning = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ending = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.shouldread = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sorting = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subtitle = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
