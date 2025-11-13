using System;

namespace core.config
{
	// Token: 0x02001D7C RID: 7548
	public class ILimitedAdastraActivityRewardInfo : IConfigItem
	{
		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x0600DD32 RID: 56626 RVA: 0x003D53FC File Offset: 0x003D35FC
		// (set) Token: 0x0600DD33 RID: 56627 RVA: 0x003D5404 File Offset: 0x003D3604
		public string endTime { get; set; }

		// Token: 0x170015B0 RID: 5552
		// (get) Token: 0x0600DD34 RID: 56628 RVA: 0x003D540D File Offset: 0x003D360D
		// (set) Token: 0x0600DD35 RID: 56629 RVA: 0x003D5415 File Offset: 0x003D3615
		public string reward { get; set; }

		// Token: 0x170015B1 RID: 5553
		// (get) Token: 0x0600DD36 RID: 56630 RVA: 0x003D541E File Offset: 0x003D361E
		// (set) Token: 0x0600DD37 RID: 56631 RVA: 0x003D5426 File Offset: 0x003D3626
		public string unlockTime { get; set; }

		// Token: 0x170015B2 RID: 5554
		// (get) Token: 0x0600DD38 RID: 56632 RVA: 0x003D542F File Offset: 0x003D362F
		// (set) Token: 0x0600DD39 RID: 56633 RVA: 0x003D5437 File Offset: 0x003D3637
		public int condition { get; set; }

		// Token: 0x170015B3 RID: 5555
		// (get) Token: 0x0600DD3A RID: 56634 RVA: 0x003D5440 File Offset: 0x003D3640
		// (set) Token: 0x0600DD3B RID: 56635 RVA: 0x003D5448 File Offset: 0x003D3648
		public int id { get; set; }

		// Token: 0x170015B4 RID: 5556
		// (get) Token: 0x0600DD3C RID: 56636 RVA: 0x003D5451 File Offset: 0x003D3651
		// (set) Token: 0x0600DD3D RID: 56637 RVA: 0x003D5459 File Offset: 0x003D3659
		public int type { get; set; }

		// Token: 0x0600DD3E RID: 56638 RVA: 0x003D5464 File Offset: 0x003D3664
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.condition = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.endTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlockTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
