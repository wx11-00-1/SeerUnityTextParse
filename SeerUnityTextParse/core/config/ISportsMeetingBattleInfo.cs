using System;

namespace core.config
{
	// Token: 0x02001E28 RID: 7720
	public class ISportsMeetingBattleInfo : IConfigItem
	{
		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x0600E49C RID: 58524 RVA: 0x003DE954 File Offset: 0x003DCB54
		// (set) Token: 0x0600E49D RID: 58525 RVA: 0x003DE95C File Offset: 0x003DCB5C
		public string battelattack { get; set; }

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x0600E49E RID: 58526 RVA: 0x003DE965 File Offset: 0x003DCB65
		// (set) Token: 0x0600E49F RID: 58527 RVA: 0x003DE96D File Offset: 0x003DCB6D
		public string battelhp { get; set; }

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x0600E4A0 RID: 58528 RVA: 0x003DE976 File Offset: 0x003DCB76
		// (set) Token: 0x0600E4A1 RID: 58529 RVA: 0x003DE97E File Offset: 0x003DCB7E
		public string icon { get; set; }

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x0600E4A2 RID: 58530 RVA: 0x003DE987 File Offset: 0x003DCB87
		// (set) Token: 0x0600E4A3 RID: 58531 RVA: 0x003DE98F File Offset: 0x003DCB8F
		public string name { get; set; }

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x0600E4A4 RID: 58532 RVA: 0x003DE998 File Offset: 0x003DCB98
		// (set) Token: 0x0600E4A5 RID: 58533 RVA: 0x003DE9A0 File Offset: 0x003DCBA0
		public int attackup { get; set; }

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x0600E4A6 RID: 58534 RVA: 0x003DE9A9 File Offset: 0x003DCBA9
		// (set) Token: 0x0600E4A7 RID: 58535 RVA: 0x003DE9B1 File Offset: 0x003DCBB1
		public int hpup { get; set; }

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x0600E4A8 RID: 58536 RVA: 0x003DE9BA File Offset: 0x003DCBBA
		// (set) Token: 0x0600E4A9 RID: 58537 RVA: 0x003DE9C2 File Offset: 0x003DCBC2
		public int id { get; set; }

		// Token: 0x0600E4AA RID: 58538 RVA: 0x003DE9CC File Offset: 0x003DCBCC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.attackup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.battelattack = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.battelhp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.hpup = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
