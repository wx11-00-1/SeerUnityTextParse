using System;

namespace core.config
{
	// Token: 0x0200219D RID: 8605
	public class IBraveTowerInfo : IConfigItem
	{
		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x060100E6 RID: 65766 RVA: 0x004822A4 File Offset: 0x004804A4
		// (set) Token: 0x060100E7 RID: 65767 RVA: 0x004822AC File Offset: 0x004804AC
		public string bigbossid { get; set; }

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x060100E8 RID: 65768 RVA: 0x004822B5 File Offset: 0x004804B5
		// (set) Token: 0x060100E9 RID: 65769 RVA: 0x004822BD File Offset: 0x004804BD
		public string bossgettext { get; set; }

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x060100EA RID: 65770 RVA: 0x004822C6 File Offset: 0x004804C6
		// (set) Token: 0x060100EB RID: 65771 RVA: 0x004822CE File Offset: 0x004804CE
		public string bosslist { get; set; }

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x060100EC RID: 65772 RVA: 0x004822D7 File Offset: 0x004804D7
		// (set) Token: 0x060100ED RID: 65773 RVA: 0x004822DF File Offset: 0x004804DF
		public string raidunlocktext { get; set; }

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x060100EE RID: 65774 RVA: 0x004822E8 File Offset: 0x004804E8
		// (set) Token: 0x060100EF RID: 65775 RVA: 0x004822F0 File Offset: 0x004804F0
		public string rewardid { get; set; }

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x060100F0 RID: 65776 RVA: 0x004822F9 File Offset: 0x004804F9
		// (set) Token: 0x060100F1 RID: 65777 RVA: 0x00482301 File Offset: 0x00480501
		public string rewardnum { get; set; }

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x060100F2 RID: 65778 RVA: 0x0048230A File Offset: 0x0048050A
		// (set) Token: 0x060100F3 RID: 65779 RVA: 0x00482312 File Offset: 0x00480512
		public string rewardtype { get; set; }

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x060100F4 RID: 65780 RVA: 0x0048231B File Offset: 0x0048051B
		// (set) Token: 0x060100F5 RID: 65781 RVA: 0x00482323 File Offset: 0x00480523
		public string sebossid { get; set; }

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x060100F6 RID: 65782 RVA: 0x0048232C File Offset: 0x0048052C
		// (set) Token: 0x060100F7 RID: 65783 RVA: 0x00482334 File Offset: 0x00480534
		public int bossgetarg { get; set; }

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x060100F8 RID: 65784 RVA: 0x0048233D File Offset: 0x0048053D
		// (set) Token: 0x060100F9 RID: 65785 RVA: 0x00482345 File Offset: 0x00480545
		public int id { get; set; }

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x060100FA RID: 65786 RVA: 0x0048234E File Offset: 0x0048054E
		// (set) Token: 0x060100FB RID: 65787 RVA: 0x00482356 File Offset: 0x00480556
		public int raidunlockarg { get; set; }

		// Token: 0x060100FC RID: 65788 RVA: 0x00482360 File Offset: 0x00480560
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bigbossid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bossgetarg = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bossgettext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bosslist = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.raidunlockarg = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.raidunlocktext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardnum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sebossid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
