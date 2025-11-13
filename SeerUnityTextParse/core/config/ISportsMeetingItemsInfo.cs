using System;

namespace core.config
{
	// Token: 0x02001E2C RID: 7724
	public class ISportsMeetingItemsInfo : IConfigItem
	{
		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x0600E4C6 RID: 58566 RVA: 0x003DEC78 File Offset: 0x003DCE78
		// (set) Token: 0x0600E4C7 RID: 58567 RVA: 0x003DEC80 File Offset: 0x003DCE80
		public string icon { get; set; }

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x0600E4C8 RID: 58568 RVA: 0x003DEC89 File Offset: 0x003DCE89
		// (set) Token: 0x0600E4C9 RID: 58569 RVA: 0x003DEC91 File Offset: 0x003DCE91
		public string name { get; set; }

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x0600E4CA RID: 58570 RVA: 0x003DEC9A File Offset: 0x003DCE9A
		// (set) Token: 0x0600E4CB RID: 58571 RVA: 0x003DECA2 File Offset: 0x003DCEA2
		public string skilldescribe { get; set; }

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x0600E4CC RID: 58572 RVA: 0x003DECAB File Offset: 0x003DCEAB
		// (set) Token: 0x0600E4CD RID: 58573 RVA: 0x003DECB3 File Offset: 0x003DCEB3
		public int id { get; set; }

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x0600E4CE RID: 58574 RVA: 0x003DECBC File Offset: 0x003DCEBC
		// (set) Token: 0x0600E4CF RID: 58575 RVA: 0x003DECC4 File Offset: 0x003DCEC4
		public int skill { get; set; }

		// Token: 0x0600E4D0 RID: 58576 RVA: 0x003DECD0 File Offset: 0x003DCED0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skilldescribe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
