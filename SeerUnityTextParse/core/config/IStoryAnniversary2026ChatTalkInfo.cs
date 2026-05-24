using System;

namespace core.config
{
	// Token: 0x020026BB RID: 9915
	public class IStoryAnniversary2026ChatTalkInfo : IConfigItem
	{
		// Token: 0x170021FE RID: 8702
		// (get) Token: 0x060134CA RID: 79050 RVA: 0x00523358 File Offset: 0x00521558
		// (set) Token: 0x060134CB RID: 79051 RVA: 0x00523360 File Offset: 0x00521560
		public string answer { get; set; }

		// Token: 0x170021FF RID: 8703
		// (get) Token: 0x060134CC RID: 79052 RVA: 0x00523369 File Offset: 0x00521569
		// (set) Token: 0x060134CD RID: 79053 RVA: 0x00523371 File Offset: 0x00521571
		public string deal { get; set; }

		// Token: 0x17002200 RID: 8704
		// (get) Token: 0x060134CE RID: 79054 RVA: 0x0052337A File Offset: 0x0052157A
		// (set) Token: 0x060134CF RID: 79055 RVA: 0x00523382 File Offset: 0x00521582
		public string msg { get; set; }

		// Token: 0x17002201 RID: 8705
		// (get) Token: 0x060134D0 RID: 79056 RVA: 0x0052338B File Offset: 0x0052158B
		// (set) Token: 0x060134D1 RID: 79057 RVA: 0x00523393 File Offset: 0x00521593
		public int chatId { get; set; }

		// Token: 0x17002202 RID: 8706
		// (get) Token: 0x060134D2 RID: 79058 RVA: 0x0052339C File Offset: 0x0052159C
		// (set) Token: 0x060134D3 RID: 79059 RVA: 0x005233A4 File Offset: 0x005215A4
		public int end { get; set; }

		// Token: 0x17002203 RID: 8707
		// (get) Token: 0x060134D4 RID: 79060 RVA: 0x005233AD File Offset: 0x005215AD
		// (set) Token: 0x060134D5 RID: 79061 RVA: 0x005233B5 File Offset: 0x005215B5
		public int groupId { get; set; }

		// Token: 0x17002204 RID: 8708
		// (get) Token: 0x060134D6 RID: 79062 RVA: 0x005233BE File Offset: 0x005215BE
		// (set) Token: 0x060134D7 RID: 79063 RVA: 0x005233C6 File Offset: 0x005215C6
		public int id { get; set; }

		// Token: 0x17002205 RID: 8709
		// (get) Token: 0x060134D8 RID: 79064 RVA: 0x005233CF File Offset: 0x005215CF
		// (set) Token: 0x060134D9 RID: 79065 RVA: 0x005233D7 File Offset: 0x005215D7
		public int linkNpc { get; set; }

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x060134DA RID: 79066 RVA: 0x005233E0 File Offset: 0x005215E0
		// (set) Token: 0x060134DB RID: 79067 RVA: 0x005233E8 File Offset: 0x005215E8
		public int talker { get; set; }

		// Token: 0x060134DC RID: 79068 RVA: 0x005233F4 File Offset: 0x005215F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.answer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.chatId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.deal = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.end = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.groupId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.linkNpc = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.talker = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
