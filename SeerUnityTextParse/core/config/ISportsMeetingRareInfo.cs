using System;

namespace core.config
{
	// Token: 0x02001E2E RID: 7726
	public class ISportsMeetingRareInfo : IConfigItem
	{
		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x0600E4D6 RID: 58582 RVA: 0x003DEDB8 File Offset: 0x003DCFB8
		// (set) Token: 0x0600E4D7 RID: 58583 RVA: 0x003DEDC0 File Offset: 0x003DCFC0
		public string battlerare { get; set; }

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x0600E4D8 RID: 58584 RVA: 0x003DEDC9 File Offset: 0x003DCFC9
		// (set) Token: 0x0600E4D9 RID: 58585 RVA: 0x003DEDD1 File Offset: 0x003DCFD1
		public string eventrare { get; set; }

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x0600E4DA RID: 58586 RVA: 0x003DEDDA File Offset: 0x003DCFDA
		// (set) Token: 0x0600E4DB RID: 58587 RVA: 0x003DEDE2 File Offset: 0x003DCFE2
		public int id { get; set; }

		// Token: 0x0600E4DC RID: 58588 RVA: 0x003DEDEB File Offset: 0x003DCFEB
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.battlerare = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.eventrare = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
