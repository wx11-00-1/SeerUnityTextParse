using System;

namespace core.config.Wishsuit
{
	// Token: 0x02001EE6 RID: 7910
	public class IWishsuitItem
	{
		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x0600ECC6 RID: 60614 RVA: 0x003F0860 File Offset: 0x003EEA60
		// (set) Token: 0x0600ECC7 RID: 60615 RVA: 0x003F0868 File Offset: 0x003EEA68
		public string SuitName { get; set; }

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x0600ECC8 RID: 60616 RVA: 0x003F0871 File Offset: 0x003EEA71
		// (set) Token: 0x0600ECC9 RID: 60617 RVA: 0x003F0879 File Offset: 0x003EEA79
		public int SuitID { get; set; }

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x0600ECCA RID: 60618 RVA: 0x003F0882 File Offset: 0x003EEA82
		// (set) Token: 0x0600ECCB RID: 60619 RVA: 0x003F088A File Offset: 0x003EEA8A
		public int SuitPart1 { get; set; }

		// Token: 0x17001AAF RID: 6831
		// (get) Token: 0x0600ECCC RID: 60620 RVA: 0x003F0893 File Offset: 0x003EEA93
		// (set) Token: 0x0600ECCD RID: 60621 RVA: 0x003F089B File Offset: 0x003EEA9B
		public int SuitPart2 { get; set; }

		// Token: 0x17001AB0 RID: 6832
		// (get) Token: 0x0600ECCE RID: 60622 RVA: 0x003F08A4 File Offset: 0x003EEAA4
		// (set) Token: 0x0600ECCF RID: 60623 RVA: 0x003F08AC File Offset: 0x003EEAAC
		public int SuitPart3 { get; set; }

		// Token: 0x17001AB1 RID: 6833
		// (get) Token: 0x0600ECD0 RID: 60624 RVA: 0x003F08B5 File Offset: 0x003EEAB5
		// (set) Token: 0x0600ECD1 RID: 60625 RVA: 0x003F08BD File Offset: 0x003EEABD
		public int SuitPart4 { get; set; }

		// Token: 0x17001AB2 RID: 6834
		// (get) Token: 0x0600ECD2 RID: 60626 RVA: 0x003F08C6 File Offset: 0x003EEAC6
		// (set) Token: 0x0600ECD3 RID: 60627 RVA: 0x003F08CE File Offset: 0x003EEACE
		public int SuitPart5 { get; set; }

		// Token: 0x17001AB3 RID: 6835
		// (get) Token: 0x0600ECD4 RID: 60628 RVA: 0x003F08D7 File Offset: 0x003EEAD7
		// (set) Token: 0x0600ECD5 RID: 60629 RVA: 0x003F08DF File Offset: 0x003EEADF
		public int WishrankID { get; set; }

		// Token: 0x17001AB4 RID: 6836
		// (get) Token: 0x0600ECD6 RID: 60630 RVA: 0x003F08E8 File Offset: 0x003EEAE8
		// (set) Token: 0x0600ECD7 RID: 60631 RVA: 0x003F08F0 File Offset: 0x003EEAF0
		public int WishsuitID { get; set; }

		// Token: 0x0600ECD8 RID: 60632 RVA: 0x003F08FC File Offset: 0x003EEAFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.SuitID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SuitName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.SuitPart1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SuitPart2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SuitPart3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SuitPart4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SuitPart5 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.WishrankID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.WishsuitID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
