using System;

namespace core.config.peakCrusade_levelRules
{
	// Token: 0x02001F76 RID: 8054
	public class IItemItem
	{
		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x0600F1AC RID: 61868 RVA: 0x003F6605 File Offset: 0x003F4805
		// (set) Token: 0x0600F1AD RID: 61869 RVA: 0x003F660D File Offset: 0x003F480D
		public int danNumber { get; set; }

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x0600F1AE RID: 61870 RVA: 0x003F6616 File Offset: 0x003F4816
		// (set) Token: 0x0600F1AF RID: 61871 RVA: 0x003F661E File Offset: 0x003F481E
		public int ladderLv { get; set; }

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x0600F1B0 RID: 61872 RVA: 0x003F6627 File Offset: 0x003F4827
		// (set) Token: 0x0600F1B1 RID: 61873 RVA: 0x003F662F File Offset: 0x003F482F
		public int star { get; set; }

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x0600F1B2 RID: 61874 RVA: 0x003F6638 File Offset: 0x003F4838
		// (set) Token: 0x0600F1B3 RID: 61875 RVA: 0x003F6640 File Offset: 0x003F4840
		public int starLv { get; set; }

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x0600F1B4 RID: 61876 RVA: 0x003F6649 File Offset: 0x003F4849
		// (set) Token: 0x0600F1B5 RID: 61877 RVA: 0x003F6651 File Offset: 0x003F4851
		public string title { get; set; }

		// Token: 0x0600F1B6 RID: 61878 RVA: 0x003F665C File Offset: 0x003F485C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.danNumber = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ladderLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.star = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
