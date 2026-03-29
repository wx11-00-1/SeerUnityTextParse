using System;

namespace core.config
{
	// Token: 0x0200213F RID: 8511
	public class IAutocardScreenInfo : IConfigItem
	{
		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x0600FCF6 RID: 64758 RVA: 0x0047D7D8 File Offset: 0x0047B9D8
		// (set) Token: 0x0600FCF7 RID: 64759 RVA: 0x0047D7E0 File Offset: 0x0047B9E0
		public string jumpToLink { get; set; }

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x0600FCF8 RID: 64760 RVA: 0x0047D7E9 File Offset: 0x0047B9E9
		// (set) Token: 0x0600FCF9 RID: 64761 RVA: 0x0047D7F1 File Offset: 0x0047B9F1
		public string source { get; set; }

		// Token: 0x170014FE RID: 5374
		// (get) Token: 0x0600FCFA RID: 64762 RVA: 0x0047D7FA File Offset: 0x0047B9FA
		// (set) Token: 0x0600FCFB RID: 64763 RVA: 0x0047D802 File Offset: 0x0047BA02
		public int duration { get; set; }

		// Token: 0x170014FF RID: 5375
		// (get) Token: 0x0600FCFC RID: 64764 RVA: 0x0047D80B File Offset: 0x0047BA0B
		// (set) Token: 0x0600FCFD RID: 64765 RVA: 0x0047D813 File Offset: 0x0047BA13
		public int endTime { get; set; }

		// Token: 0x17001500 RID: 5376
		// (get) Token: 0x0600FCFE RID: 64766 RVA: 0x0047D81C File Offset: 0x0047BA1C
		// (set) Token: 0x0600FCFF RID: 64767 RVA: 0x0047D824 File Offset: 0x0047BA24
		public int id { get; set; }

		// Token: 0x17001501 RID: 5377
		// (get) Token: 0x0600FD00 RID: 64768 RVA: 0x0047D82D File Offset: 0x0047BA2D
		// (set) Token: 0x0600FD01 RID: 64769 RVA: 0x0047D835 File Offset: 0x0047BA35
		public int jumpTo { get; set; }

		// Token: 0x17001502 RID: 5378
		// (get) Token: 0x0600FD02 RID: 64770 RVA: 0x0047D83E File Offset: 0x0047BA3E
		// (set) Token: 0x0600FD03 RID: 64771 RVA: 0x0047D846 File Offset: 0x0047BA46
		public int sort { get; set; }

		// Token: 0x17001503 RID: 5379
		// (get) Token: 0x0600FD04 RID: 64772 RVA: 0x0047D84F File Offset: 0x0047BA4F
		// (set) Token: 0x0600FD05 RID: 64773 RVA: 0x0047D857 File Offset: 0x0047BA57
		public int startTime { get; set; }

		// Token: 0x0600FD06 RID: 64774 RVA: 0x0047D860 File Offset: 0x0047BA60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.duration = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.endTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jumpTo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jumpToLink = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.source = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.startTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
