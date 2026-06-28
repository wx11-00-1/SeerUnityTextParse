using System;

namespace core.config
{
	// Token: 0x02002663 RID: 9827
	public class IDayDreamStoryConfigInfo : IConfigItem
	{
		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x0601345B RID: 78939 RVA: 0x005532B0 File Offset: 0x005514B0
		// (set) Token: 0x0601345C RID: 78940 RVA: 0x005532B8 File Offset: 0x005514B8
		public string a { get; set; }

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x0601345D RID: 78941 RVA: 0x005532C1 File Offset: 0x005514C1
		// (set) Token: 0x0601345E RID: 78942 RVA: 0x005532C9 File Offset: 0x005514C9
		public string b { get; set; }

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x0601345F RID: 78943 RVA: 0x005532D2 File Offset: 0x005514D2
		// (set) Token: 0x06013460 RID: 78944 RVA: 0x005532DA File Offset: 0x005514DA
		public string c { get; set; }

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06013461 RID: 78945 RVA: 0x005532E3 File Offset: 0x005514E3
		// (set) Token: 0x06013462 RID: 78946 RVA: 0x005532EB File Offset: 0x005514EB
		public string status { get; set; }

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06013463 RID: 78947 RVA: 0x005532F4 File Offset: 0x005514F4
		// (set) Token: 0x06013464 RID: 78948 RVA: 0x005532FC File Offset: 0x005514FC
		public int id { get; set; }

		// Token: 0x06013465 RID: 78949 RVA: 0x00553308 File Offset: 0x00551508
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.a = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.b = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.c = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.status = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
