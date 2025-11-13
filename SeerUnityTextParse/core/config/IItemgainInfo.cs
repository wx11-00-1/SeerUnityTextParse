using System;

namespace core.config
{
	// Token: 0x02001D6A RID: 7530
	public class IItemgainInfo : IConfigItem
	{
		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x0600DC94 RID: 56468 RVA: 0x003D483C File Offset: 0x003D2A3C
		// (set) Token: 0x0600DC95 RID: 56469 RVA: 0x003D4844 File Offset: 0x003D2A44
		public string target { get; set; }

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x0600DC96 RID: 56470 RVA: 0x003D484D File Offset: 0x003D2A4D
		// (set) Token: 0x0600DC97 RID: 56471 RVA: 0x003D4855 File Offset: 0x003D2A55
		public string text { get; set; }

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x0600DC98 RID: 56472 RVA: 0x003D485E File Offset: 0x003D2A5E
		// (set) Token: 0x0600DC99 RID: 56473 RVA: 0x003D4866 File Offset: 0x003D2A66
		public int id { get; set; }

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x0600DC9A RID: 56474 RVA: 0x003D486F File Offset: 0x003D2A6F
		// (set) Token: 0x0600DC9B RID: 56475 RVA: 0x003D4877 File Offset: 0x003D2A77
		public int type { get; set; }

		// Token: 0x0600DC9C RID: 56476 RVA: 0x003D4880 File Offset: 0x003D2A80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
