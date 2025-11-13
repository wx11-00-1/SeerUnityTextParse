using System;

namespace core.config
{
	// Token: 0x02001CB2 RID: 7346
	public class IBadgeBattlePassRewardInfo : IConfigItem
	{
		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x0600D4F4 RID: 54516 RVA: 0x003CB26C File Offset: 0x003C946C
		// (set) Token: 0x0600D4F5 RID: 54517 RVA: 0x003CB274 File Offset: 0x003C9474
		public string freereward { get; set; }

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x0600D4F6 RID: 54518 RVA: 0x003CB27D File Offset: 0x003C947D
		// (set) Token: 0x0600D4F7 RID: 54519 RVA: 0x003CB285 File Offset: 0x003C9485
		public string paidreward { get; set; }

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x0600D4F8 RID: 54520 RVA: 0x003CB28E File Offset: 0x003C948E
		// (set) Token: 0x0600D4F9 RID: 54521 RVA: 0x003CB296 File Offset: 0x003C9496
		public int diamondnum { get; set; }

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x0600D4FA RID: 54522 RVA: 0x003CB29F File Offset: 0x003C949F
		// (set) Token: 0x0600D4FB RID: 54523 RVA: 0x003CB2A7 File Offset: 0x003C94A7
		public int exp { get; set; }

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x0600D4FC RID: 54524 RVA: 0x003CB2B0 File Offset: 0x003C94B0
		// (set) Token: 0x0600D4FD RID: 54525 RVA: 0x003CB2B8 File Offset: 0x003C94B8
		public int id { get; set; }

		// Token: 0x0600D4FE RID: 54526 RVA: 0x003CB2C4 File Offset: 0x003C94C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.diamondnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.freereward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.paidreward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
