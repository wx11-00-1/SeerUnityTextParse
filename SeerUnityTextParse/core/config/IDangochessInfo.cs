using System;

namespace core.config
{
	// Token: 0x02001F85 RID: 8069
	public class IDangochessInfo : IConfigItem
	{
		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x0600F0F0 RID: 61680 RVA: 0x00433A64 File Offset: 0x00431C64
		// (set) Token: 0x0600F0F1 RID: 61681 RVA: 0x00433A6C File Offset: 0x00431C6C
		public string cardid { get; set; }

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x0600F0F2 RID: 61682 RVA: 0x00433A75 File Offset: 0x00431C75
		// (set) Token: 0x0600F0F3 RID: 61683 RVA: 0x00433A7D File Offset: 0x00431C7D
		public string firstreward { get; set; }

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x0600F0F4 RID: 61684 RVA: 0x00433A86 File Offset: 0x00431C86
		// (set) Token: 0x0600F0F5 RID: 61685 RVA: 0x00433A8E File Offset: 0x00431C8E
		public string GuideCard { get; set; }

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x0600F0F6 RID: 61686 RVA: 0x00433A97 File Offset: 0x00431C97
		// (set) Token: 0x0600F0F7 RID: 61687 RVA: 0x00433A9F File Offset: 0x00431C9F
		public string starttime { get; set; }

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x0600F0F8 RID: 61688 RVA: 0x00433AA8 File Offset: 0x00431CA8
		// (set) Token: 0x0600F0F9 RID: 61689 RVA: 0x00433AB0 File Offset: 0x00431CB0
		public int chapterid { get; set; }

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x0600F0FA RID: 61690 RVA: 0x00433AB9 File Offset: 0x00431CB9
		// (set) Token: 0x0600F0FB RID: 61691 RVA: 0x00433AC1 File Offset: 0x00431CC1
		public int dangoID { get; set; }

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x0600F0FC RID: 61692 RVA: 0x00433ACA File Offset: 0x00431CCA
		// (set) Token: 0x0600F0FD RID: 61693 RVA: 0x00433AD2 File Offset: 0x00431CD2
		public int id { get; set; }

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x0600F0FE RID: 61694 RVA: 0x00433ADB File Offset: 0x00431CDB
		// (set) Token: 0x0600F0FF RID: 61695 RVA: 0x00433AE3 File Offset: 0x00431CE3
		public int stageid { get; set; }

		// Token: 0x0600F100 RID: 61696 RVA: 0x00433AEC File Offset: 0x00431CEC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.GuideCard = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.cardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.dangoID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.firstreward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stageid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
