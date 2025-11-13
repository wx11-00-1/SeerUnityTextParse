using System;

namespace core.config
{
	// Token: 0x02001D6C RID: 7532
	public class IJumptargetInfo : IConfigItem
	{
		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x0600DCA2 RID: 56482 RVA: 0x003D4954 File Offset: 0x003D2B54
		// (set) Token: 0x0600DCA3 RID: 56483 RVA: 0x003D495C File Offset: 0x003D2B5C
		public string name { get; set; }

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x0600DCA4 RID: 56484 RVA: 0x003D4965 File Offset: 0x003D2B65
		// (set) Token: 0x0600DCA5 RID: 56485 RVA: 0x003D496D File Offset: 0x003D2B6D
		public string paras { get; set; }

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x0600DCA6 RID: 56486 RVA: 0x003D4976 File Offset: 0x003D2B76
		// (set) Token: 0x0600DCA7 RID: 56487 RVA: 0x003D497E File Offset: 0x003D2B7E
		public int id { get; set; }

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x0600DCA8 RID: 56488 RVA: 0x003D4987 File Offset: 0x003D2B87
		// (set) Token: 0x0600DCA9 RID: 56489 RVA: 0x003D498F File Offset: 0x003D2B8F
		public int target { get; set; }

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x0600DCAA RID: 56490 RVA: 0x003D4998 File Offset: 0x003D2B98
		// (set) Token: 0x0600DCAB RID: 56491 RVA: 0x003D49A0 File Offset: 0x003D2BA0
		public int type { get; set; }

		// Token: 0x0600DCAC RID: 56492 RVA: 0x003D49AC File Offset: 0x003D2BAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.paras = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
