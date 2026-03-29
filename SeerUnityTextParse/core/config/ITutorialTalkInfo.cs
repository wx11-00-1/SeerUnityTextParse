using System;

namespace core.config
{
	// Token: 0x020023F1 RID: 9201
	public class ITutorialTalkInfo : IConfigItem
	{
		// Token: 0x1700217D RID: 8573
		// (get) Token: 0x06011B5C RID: 72540 RVA: 0x004A2778 File Offset: 0x004A0978
		// (set) Token: 0x06011B5D RID: 72541 RVA: 0x004A2780 File Offset: 0x004A0980
		public string isPic { get; set; }

		// Token: 0x1700217E RID: 8574
		// (get) Token: 0x06011B5E RID: 72542 RVA: 0x004A2789 File Offset: 0x004A0989
		// (set) Token: 0x06011B5F RID: 72543 RVA: 0x004A2791 File Offset: 0x004A0991
		public string msg { get; set; }

		// Token: 0x1700217F RID: 8575
		// (get) Token: 0x06011B60 RID: 72544 RVA: 0x004A279A File Offset: 0x004A099A
		// (set) Token: 0x06011B61 RID: 72545 RVA: 0x004A27A2 File Offset: 0x004A09A2
		public int dir { get; set; }

		// Token: 0x17002180 RID: 8576
		// (get) Token: 0x06011B62 RID: 72546 RVA: 0x004A27AB File Offset: 0x004A09AB
		// (set) Token: 0x06011B63 RID: 72547 RVA: 0x004A27B3 File Offset: 0x004A09B3
		public int groupId { get; set; }

		// Token: 0x17002181 RID: 8577
		// (get) Token: 0x06011B64 RID: 72548 RVA: 0x004A27BC File Offset: 0x004A09BC
		// (set) Token: 0x06011B65 RID: 72549 RVA: 0x004A27C4 File Offset: 0x004A09C4
		public int id { get; set; }

		// Token: 0x17002182 RID: 8578
		// (get) Token: 0x06011B66 RID: 72550 RVA: 0x004A27CD File Offset: 0x004A09CD
		// (set) Token: 0x06011B67 RID: 72551 RVA: 0x004A27D5 File Offset: 0x004A09D5
		public int npcId { get; set; }

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x06011B68 RID: 72552 RVA: 0x004A27DE File Offset: 0x004A09DE
		// (set) Token: 0x06011B69 RID: 72553 RVA: 0x004A27E6 File Offset: 0x004A09E6
		public int Panel { get; set; }

		// Token: 0x06011B6A RID: 72554 RVA: 0x004A27F0 File Offset: 0x004A09F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Panel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.dir = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.groupId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isPic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.npcId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
