using System;

namespace core.config
{
	// Token: 0x02001D12 RID: 7442
	public class ICrystalLegendEventInfo : IConfigItem
	{
		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x0600D93A RID: 55610 RVA: 0x003D045C File Offset: 0x003CE65C
		// (set) Token: 0x0600D93B RID: 55611 RVA: 0x003D0464 File Offset: 0x003CE664
		public string answerTxt1 { get; set; }

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x0600D93C RID: 55612 RVA: 0x003D046D File Offset: 0x003CE66D
		// (set) Token: 0x0600D93D RID: 55613 RVA: 0x003D0475 File Offset: 0x003CE675
		public string answerTxt2 { get; set; }

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x0600D93E RID: 55614 RVA: 0x003D047E File Offset: 0x003CE67E
		// (set) Token: 0x0600D93F RID: 55615 RVA: 0x003D0486 File Offset: 0x003CE686
		public string answerTxt3 { get; set; }

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600D940 RID: 55616 RVA: 0x003D048F File Offset: 0x003CE68F
		// (set) Token: 0x0600D941 RID: 55617 RVA: 0x003D0497 File Offset: 0x003CE697
		public string eventTxt { get; set; }

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x0600D942 RID: 55618 RVA: 0x003D04A0 File Offset: 0x003CE6A0
		// (set) Token: 0x0600D943 RID: 55619 RVA: 0x003D04A8 File Offset: 0x003CE6A8
		public string picName { get; set; }

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x0600D944 RID: 55620 RVA: 0x003D04B1 File Offset: 0x003CE6B1
		// (set) Token: 0x0600D945 RID: 55621 RVA: 0x003D04B9 File Offset: 0x003CE6B9
		public int id { get; set; }

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x0600D946 RID: 55622 RVA: 0x003D04C2 File Offset: 0x003CE6C2
		// (set) Token: 0x0600D947 RID: 55623 RVA: 0x003D04CA File Offset: 0x003CE6CA
		public int limitNum { get; set; }

		// Token: 0x0600D948 RID: 55624 RVA: 0x003D04D4 File Offset: 0x003CE6D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.answerTxt1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.answerTxt2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.answerTxt3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventTxt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.limitNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.picName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
