using System;

namespace core.config
{
	// Token: 0x02001D68 RID: 7528
	public class IHelpTipsInfo : IConfigItem
	{
		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x0600DC82 RID: 56450 RVA: 0x003D46D8 File Offset: 0x003D28D8
		// (set) Token: 0x0600DC83 RID: 56451 RVA: 0x003D46E0 File Offset: 0x003D28E0
		public string desc { get; set; }

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x0600DC84 RID: 56452 RVA: 0x003D46E9 File Offset: 0x003D28E9
		// (set) Token: 0x0600DC85 RID: 56453 RVA: 0x003D46F1 File Offset: 0x003D28F1
		public string html { get; set; }

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x0600DC86 RID: 56454 RVA: 0x003D46FA File Offset: 0x003D28FA
		// (set) Token: 0x0600DC87 RID: 56455 RVA: 0x003D4702 File Offset: 0x003D2902
		public string tips { get; set; }

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x0600DC88 RID: 56456 RVA: 0x003D470B File Offset: 0x003D290B
		// (set) Token: 0x0600DC89 RID: 56457 RVA: 0x003D4713 File Offset: 0x003D2913
		public string title { get; set; }

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x0600DC8A RID: 56458 RVA: 0x003D471C File Offset: 0x003D291C
		// (set) Token: 0x0600DC8B RID: 56459 RVA: 0x003D4724 File Offset: 0x003D2924
		public int id { get; set; }

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x0600DC8C RID: 56460 RVA: 0x003D472D File Offset: 0x003D292D
		// (set) Token: 0x0600DC8D RID: 56461 RVA: 0x003D4735 File Offset: 0x003D2935
		public int type { get; set; }

		// Token: 0x0600DC8E RID: 56462 RVA: 0x003D4740 File Offset: 0x003D2940
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.html = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
