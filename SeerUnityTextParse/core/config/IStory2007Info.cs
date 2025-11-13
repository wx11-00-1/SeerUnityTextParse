using System;

namespace core.config
{
	// Token: 0x02001E6C RID: 7788
	public class IStory2007Info : IConfigItem
	{
		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x0600E796 RID: 59286 RVA: 0x003E23E4 File Offset: 0x003E05E4
		// (set) Token: 0x0600E797 RID: 59287 RVA: 0x003E23EC File Offset: 0x003E05EC
		public string param1 { get; set; }

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x0600E798 RID: 59288 RVA: 0x003E23F5 File Offset: 0x003E05F5
		// (set) Token: 0x0600E799 RID: 59289 RVA: 0x003E23FD File Offset: 0x003E05FD
		public string param2 { get; set; }

		// Token: 0x170019F3 RID: 6643
		// (get) Token: 0x0600E79A RID: 59290 RVA: 0x003E2406 File Offset: 0x003E0606
		// (set) Token: 0x0600E79B RID: 59291 RVA: 0x003E240E File Offset: 0x003E060E
		public string param3 { get; set; }

		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x0600E79C RID: 59292 RVA: 0x003E2417 File Offset: 0x003E0617
		// (set) Token: 0x0600E79D RID: 59293 RVA: 0x003E241F File Offset: 0x003E061F
		public string param4 { get; set; }

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x0600E79E RID: 59294 RVA: 0x003E2428 File Offset: 0x003E0628
		// (set) Token: 0x0600E79F RID: 59295 RVA: 0x003E2430 File Offset: 0x003E0630
		public string param5 { get; set; }

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x0600E7A0 RID: 59296 RVA: 0x003E2439 File Offset: 0x003E0639
		// (set) Token: 0x0600E7A1 RID: 59297 RVA: 0x003E2441 File Offset: 0x003E0641
		public int control { get; set; }

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x0600E7A2 RID: 59298 RVA: 0x003E244A File Offset: 0x003E064A
		// (set) Token: 0x0600E7A3 RID: 59299 RVA: 0x003E2452 File Offset: 0x003E0652
		public int id { get; set; }

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x0600E7A4 RID: 59300 RVA: 0x003E245B File Offset: 0x003E065B
		// (set) Token: 0x0600E7A5 RID: 59301 RVA: 0x003E2463 File Offset: 0x003E0663
		public int logic { get; set; }

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x0600E7A6 RID: 59302 RVA: 0x003E246C File Offset: 0x003E066C
		// (set) Token: 0x0600E7A7 RID: 59303 RVA: 0x003E2474 File Offset: 0x003E0674
		public int next { get; set; }

		// Token: 0x0600E7A8 RID: 59304 RVA: 0x003E2480 File Offset: 0x003E0680
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.logic = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.next = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param4 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
