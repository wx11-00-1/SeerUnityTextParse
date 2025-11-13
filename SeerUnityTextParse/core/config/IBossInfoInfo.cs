using System;

namespace core.config
{
	// Token: 0x02001CCC RID: 7372
	public class IBossInfoInfo : IConfigItem
	{
		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x0600D602 RID: 54786 RVA: 0x003CC624 File Offset: 0x003CA824
		// (set) Token: 0x0600D603 RID: 54787 RVA: 0x003CC62C File Offset: 0x003CA82C
		public string move { get; set; }

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x0600D604 RID: 54788 RVA: 0x003CC635 File Offset: 0x003CA835
		// (set) Token: 0x0600D605 RID: 54789 RVA: 0x003CC63D File Offset: 0x003CA83D
		public string se { get; set; }

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x0600D606 RID: 54790 RVA: 0x003CC646 File Offset: 0x003CA846
		// (set) Token: 0x0600D607 RID: 54791 RVA: 0x003CC64E File Offset: 0x003CA84E
		public int id { get; set; }

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x0600D608 RID: 54792 RVA: 0x003CC657 File Offset: 0x003CA857
		// (set) Token: 0x0600D609 RID: 54793 RVA: 0x003CC65F File Offset: 0x003CA85F
		public int level { get; set; }

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x0600D60A RID: 54794 RVA: 0x003CC668 File Offset: 0x003CA868
		// (set) Token: 0x0600D60B RID: 54795 RVA: 0x003CC670 File Offset: 0x003CA870
		public int petID { get; set; }

		// Token: 0x0600D60C RID: 54796 RVA: 0x003CC67C File Offset: 0x003CA87C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.move = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.se = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
