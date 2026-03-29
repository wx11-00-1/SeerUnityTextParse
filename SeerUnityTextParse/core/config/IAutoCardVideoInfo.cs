using System;

namespace core.config
{
	// Token: 0x02002145 RID: 8517
	public class IAutoCardVideoInfo : IConfigItem
	{
		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x0600FD3A RID: 64826 RVA: 0x0047DC98 File Offset: 0x0047BE98
		// (set) Token: 0x0600FD3B RID: 64827 RVA: 0x0047DCA0 File Offset: 0x0047BEA0
		public string Video { get; set; }

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x0600FD3C RID: 64828 RVA: 0x0047DCA9 File Offset: 0x0047BEA9
		// (set) Token: 0x0600FD3D RID: 64829 RVA: 0x0047DCB1 File Offset: 0x0047BEB1
		public string videoDes { get; set; }

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x0600FD3E RID: 64830 RVA: 0x0047DCBA File Offset: 0x0047BEBA
		// (set) Token: 0x0600FD3F RID: 64831 RVA: 0x0047DCC2 File Offset: 0x0047BEC2
		public string videoType { get; set; }

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x0600FD40 RID: 64832 RVA: 0x0047DCCB File Offset: 0x0047BECB
		// (set) Token: 0x0600FD41 RID: 64833 RVA: 0x0047DCD3 File Offset: 0x0047BED3
		public int id { get; set; }

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x0600FD42 RID: 64834 RVA: 0x0047DCDC File Offset: 0x0047BEDC
		// (set) Token: 0x0600FD43 RID: 64835 RVA: 0x0047DCE4 File Offset: 0x0047BEE4
		public int playerId { get; set; }

		// Token: 0x0600FD44 RID: 64836 RVA: 0x0047DCF0 File Offset: 0x0047BEF0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Video = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.playerId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.videoDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.videoType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
