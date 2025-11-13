using System;

namespace core.config
{
	// Token: 0x02001CAE RID: 7342
	public class IAwakenconditionInfo : IConfigItem
	{
		// Token: 0x17001244 RID: 4676
		// (get) Token: 0x0600D4C0 RID: 54464 RVA: 0x003CAEC0 File Offset: 0x003C90C0
		// (set) Token: 0x0600D4C1 RID: 54465 RVA: 0x003CAEC8 File Offset: 0x003C90C8
		public string des { get; set; }

		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x0600D4C2 RID: 54466 RVA: 0x003CAED1 File Offset: 0x003C90D1
		// (set) Token: 0x0600D4C3 RID: 54467 RVA: 0x003CAED9 File Offset: 0x003C90D9
		public string typeparam { get; set; }

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x0600D4C4 RID: 54468 RVA: 0x003CAEE2 File Offset: 0x003C90E2
		// (set) Token: 0x0600D4C5 RID: 54469 RVA: 0x003CAEEA File Offset: 0x003C90EA
		public int baseconid { get; set; }

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x0600D4C6 RID: 54470 RVA: 0x003CAEF3 File Offset: 0x003C90F3
		// (set) Token: 0x0600D4C7 RID: 54471 RVA: 0x003CAEFB File Offset: 0x003C90FB
		public int id { get; set; }

		// Token: 0x0600D4C8 RID: 54472 RVA: 0x003CAF04 File Offset: 0x003C9104
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.baseconid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.typeparam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
