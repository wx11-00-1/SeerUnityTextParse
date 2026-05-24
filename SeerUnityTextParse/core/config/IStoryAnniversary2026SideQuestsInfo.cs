using System;

namespace core.config
{
	// Token: 0x020026C5 RID: 9925
	public class IStoryAnniversary2026SideQuestsInfo : IConfigItem
	{
		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x0601353A RID: 79162 RVA: 0x00523B80 File Offset: 0x00521D80
		// (set) Token: 0x0601353B RID: 79163 RVA: 0x00523B88 File Offset: 0x00521D88
		public string answer { get; set; }

		// Token: 0x1700222D RID: 8749
		// (get) Token: 0x0601353C RID: 79164 RVA: 0x00523B91 File Offset: 0x00521D91
		// (set) Token: 0x0601353D RID: 79165 RVA: 0x00523B99 File Offset: 0x00521D99
		public string deal { get; set; }

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x0601353E RID: 79166 RVA: 0x00523BA2 File Offset: 0x00521DA2
		// (set) Token: 0x0601353F RID: 79167 RVA: 0x00523BAA File Offset: 0x00521DAA
		public string msg { get; set; }

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x06013540 RID: 79168 RVA: 0x00523BB3 File Offset: 0x00521DB3
		// (set) Token: 0x06013541 RID: 79169 RVA: 0x00523BBB File Offset: 0x00521DBB
		public string npcId { get; set; }

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x06013542 RID: 79170 RVA: 0x00523BC4 File Offset: 0x00521DC4
		// (set) Token: 0x06013543 RID: 79171 RVA: 0x00523BCC File Offset: 0x00521DCC
		public string npcname { get; set; }

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x06013544 RID: 79172 RVA: 0x00523BD5 File Offset: 0x00521DD5
		// (set) Token: 0x06013545 RID: 79173 RVA: 0x00523BDD File Offset: 0x00521DDD
		public int end { get; set; }

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x06013546 RID: 79174 RVA: 0x00523BE6 File Offset: 0x00521DE6
		// (set) Token: 0x06013547 RID: 79175 RVA: 0x00523BEE File Offset: 0x00521DEE
		public int groupId { get; set; }

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x06013548 RID: 79176 RVA: 0x00523BF7 File Offset: 0x00521DF7
		// (set) Token: 0x06013549 RID: 79177 RVA: 0x00523BFF File Offset: 0x00521DFF
		public int id { get; set; }

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x0601354A RID: 79178 RVA: 0x00523C08 File Offset: 0x00521E08
		// (set) Token: 0x0601354B RID: 79179 RVA: 0x00523C10 File Offset: 0x00521E10
		public int sidequestId { get; set; }

		// Token: 0x0601354C RID: 79180 RVA: 0x00523C1C File Offset: 0x00521E1C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.answer = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.deal = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.end = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.groupId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.npcId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.npcname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.sidequestId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
