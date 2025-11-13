using System;

namespace core.config
{
	// Token: 0x02001CB6 RID: 7350
	public class IBannerInfo : IConfigItem
	{
		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x0600D51E RID: 54558 RVA: 0x003CB580 File Offset: 0x003C9780
		// (set) Token: 0x0600D51F RID: 54559 RVA: 0x003CB588 File Offset: 0x003C9788
		public string finishtime { get; set; }

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x0600D520 RID: 54560 RVA: 0x003CB591 File Offset: 0x003C9791
		// (set) Token: 0x0600D521 RID: 54561 RVA: 0x003CB599 File Offset: 0x003C9799
		public string image { get; set; }

		// Token: 0x1700126D RID: 4717
		// (get) Token: 0x0600D522 RID: 54562 RVA: 0x003CB5A2 File Offset: 0x003C97A2
		// (set) Token: 0x0600D523 RID: 54563 RVA: 0x003CB5AA File Offset: 0x003C97AA
		public string starttime { get; set; }

		// Token: 0x1700126E RID: 4718
		// (get) Token: 0x0600D524 RID: 54564 RVA: 0x003CB5B3 File Offset: 0x003C97B3
		// (set) Token: 0x0600D525 RID: 54565 RVA: 0x003CB5BB File Offset: 0x003C97BB
		public int id { get; set; }

		// Token: 0x1700126F RID: 4719
		// (get) Token: 0x0600D526 RID: 54566 RVA: 0x003CB5C4 File Offset: 0x003C97C4
		// (set) Token: 0x0600D527 RID: 54567 RVA: 0x003CB5CC File Offset: 0x003C97CC
		public int isshow { get; set; }

		// Token: 0x17001270 RID: 4720
		// (get) Token: 0x0600D528 RID: 54568 RVA: 0x003CB5D5 File Offset: 0x003C97D5
		// (set) Token: 0x0600D529 RID: 54569 RVA: 0x003CB5DD File Offset: 0x003C97DD
		public int sort { get; set; }

		// Token: 0x17001271 RID: 4721
		// (get) Token: 0x0600D52A RID: 54570 RVA: 0x003CB5E6 File Offset: 0x003C97E6
		// (set) Token: 0x0600D52B RID: 54571 RVA: 0x003CB5EE File Offset: 0x003C97EE
		public int target { get; set; }

		// Token: 0x0600D52C RID: 54572 RVA: 0x003CB5F8 File Offset: 0x003C97F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.finishtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
