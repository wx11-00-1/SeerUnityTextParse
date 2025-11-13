using System;

namespace core.config
{
	// Token: 0x02001E6E RID: 7790
	public class IStory3001Info : IConfigItem
	{
		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x0600E7AE RID: 59310 RVA: 0x003E25A8 File Offset: 0x003E07A8
		// (set) Token: 0x0600E7AF RID: 59311 RVA: 0x003E25B0 File Offset: 0x003E07B0
		public string param1 { get; set; }

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x0600E7B0 RID: 59312 RVA: 0x003E25B9 File Offset: 0x003E07B9
		// (set) Token: 0x0600E7B1 RID: 59313 RVA: 0x003E25C1 File Offset: 0x003E07C1
		public string param2 { get; set; }

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x0600E7B2 RID: 59314 RVA: 0x003E25CA File Offset: 0x003E07CA
		// (set) Token: 0x0600E7B3 RID: 59315 RVA: 0x003E25D2 File Offset: 0x003E07D2
		public string param3 { get; set; }

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x0600E7B4 RID: 59316 RVA: 0x003E25DB File Offset: 0x003E07DB
		// (set) Token: 0x0600E7B5 RID: 59317 RVA: 0x003E25E3 File Offset: 0x003E07E3
		public string param4 { get; set; }

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x0600E7B6 RID: 59318 RVA: 0x003E25EC File Offset: 0x003E07EC
		// (set) Token: 0x0600E7B7 RID: 59319 RVA: 0x003E25F4 File Offset: 0x003E07F4
		public string param5 { get; set; }

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x0600E7B8 RID: 59320 RVA: 0x003E25FD File Offset: 0x003E07FD
		// (set) Token: 0x0600E7B9 RID: 59321 RVA: 0x003E2605 File Offset: 0x003E0805
		public float control { get; set; }

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x0600E7BA RID: 59322 RVA: 0x003E260E File Offset: 0x003E080E
		// (set) Token: 0x0600E7BB RID: 59323 RVA: 0x003E2616 File Offset: 0x003E0816
		public int id { get; set; }

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x0600E7BC RID: 59324 RVA: 0x003E261F File Offset: 0x003E081F
		// (set) Token: 0x0600E7BD RID: 59325 RVA: 0x003E2627 File Offset: 0x003E0827
		public int logic { get; set; }

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x0600E7BE RID: 59326 RVA: 0x003E2630 File Offset: 0x003E0830
		// (set) Token: 0x0600E7BF RID: 59327 RVA: 0x003E2638 File Offset: 0x003E0838
		public int next { get; set; }

		// Token: 0x0600E7C0 RID: 59328 RVA: 0x003E2644 File Offset: 0x003E0844
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.control = ByteUtil.ReadFloat(bytes, ref byteIndex);
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
