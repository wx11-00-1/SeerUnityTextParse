using System;

namespace core.config
{
	// Token: 0x02001D14 RID: 7444
	public class ICrystalLegendMapInfo : IConfigItem
	{
		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x0600D94E RID: 55630 RVA: 0x003D05E4 File Offset: 0x003CE7E4
		// (set) Token: 0x0600D94F RID: 55631 RVA: 0x003D05EC File Offset: 0x003CE7EC
		public string model1 { get; set; }

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x0600D950 RID: 55632 RVA: 0x003D05F5 File Offset: 0x003CE7F5
		// (set) Token: 0x0600D951 RID: 55633 RVA: 0x003D05FD File Offset: 0x003CE7FD
		public string model2 { get; set; }

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x0600D952 RID: 55634 RVA: 0x003D0606 File Offset: 0x003CE806
		// (set) Token: 0x0600D953 RID: 55635 RVA: 0x003D060E File Offset: 0x003CE80E
		public string model3 { get; set; }

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x0600D954 RID: 55636 RVA: 0x003D0617 File Offset: 0x003CE817
		// (set) Token: 0x0600D955 RID: 55637 RVA: 0x003D061F File Offset: 0x003CE81F
		public string model4 { get; set; }

		// Token: 0x17001429 RID: 5161
		// (get) Token: 0x0600D956 RID: 55638 RVA: 0x003D0628 File Offset: 0x003CE828
		// (set) Token: 0x0600D957 RID: 55639 RVA: 0x003D0630 File Offset: 0x003CE830
		public string model5 { get; set; }

		// Token: 0x1700142A RID: 5162
		// (get) Token: 0x0600D958 RID: 55640 RVA: 0x003D0639 File Offset: 0x003CE839
		// (set) Token: 0x0600D959 RID: 55641 RVA: 0x003D0641 File Offset: 0x003CE841
		public string model6 { get; set; }

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x0600D95A RID: 55642 RVA: 0x003D064A File Offset: 0x003CE84A
		// (set) Token: 0x0600D95B RID: 55643 RVA: 0x003D0652 File Offset: 0x003CE852
		public string nextID { get; set; }

		// Token: 0x1700142C RID: 5164
		// (get) Token: 0x0600D95C RID: 55644 RVA: 0x003D065B File Offset: 0x003CE85B
		// (set) Token: 0x0600D95D RID: 55645 RVA: 0x003D0663 File Offset: 0x003CE863
		public int id { get; set; }

		// Token: 0x1700142D RID: 5165
		// (get) Token: 0x0600D95E RID: 55646 RVA: 0x003D066C File Offset: 0x003CE86C
		// (set) Token: 0x0600D95F RID: 55647 RVA: 0x003D0674 File Offset: 0x003CE874
		public int isStart { get; set; }

		// Token: 0x1700142E RID: 5166
		// (get) Token: 0x0600D960 RID: 55648 RVA: 0x003D067D File Offset: 0x003CE87D
		// (set) Token: 0x0600D961 RID: 55649 RVA: 0x003D0685 File Offset: 0x003CE885
		public int roomID { get; set; }

		// Token: 0x0600D962 RID: 55650 RVA: 0x003D0690 File Offset: 0x003CE890
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isStart = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.model1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.model2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.model3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.model4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.model5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.model6 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.nextID = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.roomID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
