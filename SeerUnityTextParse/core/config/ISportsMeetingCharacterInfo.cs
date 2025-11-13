using System;

namespace core.config
{
	// Token: 0x02001E2A RID: 7722
	public class ISportsMeetingCharacterInfo : IConfigItem
	{
		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x0600E4B0 RID: 58544 RVA: 0x003DEAD4 File Offset: 0x003DCCD4
		// (set) Token: 0x0600E4B1 RID: 58545 RVA: 0x003DEADC File Offset: 0x003DCCDC
		public string level1value { get; set; }

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x0600E4B2 RID: 58546 RVA: 0x003DEAE5 File Offset: 0x003DCCE5
		// (set) Token: 0x0600E4B3 RID: 58547 RVA: 0x003DEAED File Offset: 0x003DCCED
		public string level2value { get; set; }

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x0600E4B4 RID: 58548 RVA: 0x003DEAF6 File Offset: 0x003DCCF6
		// (set) Token: 0x0600E4B5 RID: 58549 RVA: 0x003DEAFE File Offset: 0x003DCCFE
		public string level3value { get; set; }

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x0600E4B6 RID: 58550 RVA: 0x003DEB07 File Offset: 0x003DCD07
		// (set) Token: 0x0600E4B7 RID: 58551 RVA: 0x003DEB0F File Offset: 0x003DCD0F
		public string name { get; set; }

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x0600E4B8 RID: 58552 RVA: 0x003DEB18 File Offset: 0x003DCD18
		// (set) Token: 0x0600E4B9 RID: 58553 RVA: 0x003DEB20 File Offset: 0x003DCD20
		public string skilldescribe { get; set; }

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x0600E4BA RID: 58554 RVA: 0x003DEB29 File Offset: 0x003DCD29
		// (set) Token: 0x0600E4BB RID: 58555 RVA: 0x003DEB31 File Offset: 0x003DCD31
		public int id { get; set; }

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x0600E4BC RID: 58556 RVA: 0x003DEB3A File Offset: 0x003DCD3A
		// (set) Token: 0x0600E4BD RID: 58557 RVA: 0x003DEB42 File Offset: 0x003DCD42
		public int skill { get; set; }

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x0600E4BE RID: 58558 RVA: 0x003DEB4B File Offset: 0x003DCD4B
		// (set) Token: 0x0600E4BF RID: 58559 RVA: 0x003DEB53 File Offset: 0x003DCD53
		public int unlock { get; set; }

		// Token: 0x0600E4C0 RID: 58560 RVA: 0x003DEB5C File Offset: 0x003DCD5C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level1value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.level2value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.level3value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skilldescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
