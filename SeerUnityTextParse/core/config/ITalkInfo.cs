using System;

namespace core.config
{
	// Token: 0x02001E74 RID: 7796
	public class ITalkInfo : IConfigItem
	{
		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x0600E7EC RID: 59372 RVA: 0x003E2A30 File Offset: 0x003E0C30
		// (set) Token: 0x0600E7ED RID: 59373 RVA: 0x003E2A38 File Offset: 0x003E0C38
		public string[] answer { get; set; }

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x0600E7EE RID: 59374 RVA: 0x003E2A41 File Offset: 0x003E0C41
		// (set) Token: 0x0600E7EF RID: 59375 RVA: 0x003E2A49 File Offset: 0x003E0C49
		public string[] deal { get; set; }

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x0600E7F0 RID: 59376 RVA: 0x003E2A52 File Offset: 0x003E0C52
		// (set) Token: 0x0600E7F1 RID: 59377 RVA: 0x003E2A5A File Offset: 0x003E0C5A
		public string msg { get; set; }

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x0600E7F2 RID: 59378 RVA: 0x003E2A63 File Offset: 0x003E0C63
		// (set) Token: 0x0600E7F3 RID: 59379 RVA: 0x003E2A6B File Offset: 0x003E0C6B
		public int dir { get; set; }

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x0600E7F4 RID: 59380 RVA: 0x003E2A74 File Offset: 0x003E0C74
		// (set) Token: 0x0600E7F5 RID: 59381 RVA: 0x003E2A7C File Offset: 0x003E0C7C
		public int groupId { get; set; }

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x0600E7F6 RID: 59382 RVA: 0x003E2A85 File Offset: 0x003E0C85
		// (set) Token: 0x0600E7F7 RID: 59383 RVA: 0x003E2A8D File Offset: 0x003E0C8D
		public int id { get; set; }

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x0600E7F8 RID: 59384 RVA: 0x003E2A96 File Offset: 0x003E0C96
		// (set) Token: 0x0600E7F9 RID: 59385 RVA: 0x003E2A9E File Offset: 0x003E0C9E
		public int npcId { get; set; }

		// Token: 0x0600E7FA RID: 59386 RVA: 0x003E2AA8 File Offset: 0x003E0CA8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.answer = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.answer[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.deal = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					this.deal[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.dir = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.groupId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.npcId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
