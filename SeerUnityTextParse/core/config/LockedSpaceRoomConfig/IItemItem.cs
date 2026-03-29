using System;

namespace core.config.LockedSpaceRoomConfig
{
	// Token: 0x0200257C RID: 9596
	public class IItemItem : IConfigItem
	{
		// Token: 0x17002612 RID: 9746
		// (get) Token: 0x06012A79 RID: 76409 RVA: 0x004BDC4C File Offset: 0x004BBE4C
		// (set) Token: 0x06012A7A RID: 76410 RVA: 0x004BDC54 File Offset: 0x004BBE54
		public string param { get; set; }

		// Token: 0x17002613 RID: 9747
		// (get) Token: 0x06012A7B RID: 76411 RVA: 0x004BDC5D File Offset: 0x004BBE5D
		// (set) Token: 0x06012A7C RID: 76412 RVA: 0x004BDC65 File Offset: 0x004BBE65
		public string showDialog { get; set; }

		// Token: 0x17002614 RID: 9748
		// (get) Token: 0x06012A7D RID: 76413 RVA: 0x004BDC6E File Offset: 0x004BBE6E
		// (set) Token: 0x06012A7E RID: 76414 RVA: 0x004BDC76 File Offset: 0x004BBE76
		public string showNpc { get; set; }

		// Token: 0x17002615 RID: 9749
		// (get) Token: 0x06012A7F RID: 76415 RVA: 0x004BDC7F File Offset: 0x004BBE7F
		// (set) Token: 0x06012A80 RID: 76416 RVA: 0x004BDC87 File Offset: 0x004BBE87
		public int coreReward { get; set; }

		// Token: 0x17002616 RID: 9750
		// (get) Token: 0x06012A81 RID: 76417 RVA: 0x004BDC90 File Offset: 0x004BBE90
		// (set) Token: 0x06012A82 RID: 76418 RVA: 0x004BDC98 File Offset: 0x004BBE98
		public int id { get; set; }

		// Token: 0x17002617 RID: 9751
		// (get) Token: 0x06012A83 RID: 76419 RVA: 0x004BDCA1 File Offset: 0x004BBEA1
		// (set) Token: 0x06012A84 RID: 76420 RVA: 0x004BDCA9 File Offset: 0x004BBEA9
		public int isEnd { get; set; }

		// Token: 0x17002618 RID: 9752
		// (get) Token: 0x06012A85 RID: 76421 RVA: 0x004BDCB2 File Offset: 0x004BBEB2
		// (set) Token: 0x06012A86 RID: 76422 RVA: 0x004BDCBA File Offset: 0x004BBEBA
		public int lineID { get; set; }

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06012A87 RID: 76423 RVA: 0x004BDCC3 File Offset: 0x004BBEC3
		// (set) Token: 0x06012A88 RID: 76424 RVA: 0x004BDCCB File Offset: 0x004BBECB
		public int roomID { get; set; }

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x06012A89 RID: 76425 RVA: 0x004BDCD4 File Offset: 0x004BBED4
		// (set) Token: 0x06012A8A RID: 76426 RVA: 0x004BDCDC File Offset: 0x004BBEDC
		public int stoneReward { get; set; }

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x06012A8B RID: 76427 RVA: 0x004BDCE5 File Offset: 0x004BBEE5
		// (set) Token: 0x06012A8C RID: 76428 RVA: 0x004BDCED File Offset: 0x004BBEED
		public int type { get; set; }

		// Token: 0x06012A8D RID: 76429 RVA: 0x004BDCF8 File Offset: 0x004BBEF8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.coreReward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isEnd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.lineID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.roomID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.showDialog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.showNpc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stoneReward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
