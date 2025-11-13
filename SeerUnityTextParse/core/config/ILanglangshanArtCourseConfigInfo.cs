using System;

namespace core.config
{
	// Token: 0x02001D6E RID: 7534
	public class ILanglangshanArtCourseConfigInfo : IConfigItem
	{
		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x0600DCB2 RID: 56498 RVA: 0x003D4A8C File Offset: 0x003D2C8C
		// (set) Token: 0x0600DCB3 RID: 56499 RVA: 0x003D4A94 File Offset: 0x003D2C94
		public string reward { get; set; }

		// Token: 0x1700157E RID: 5502
		// (get) Token: 0x0600DCB4 RID: 56500 RVA: 0x003D4A9D File Offset: 0x003D2C9D
		// (set) Token: 0x0600DCB5 RID: 56501 RVA: 0x003D4AA5 File Offset: 0x003D2CA5
		public int difficulty { get; set; }

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x0600DCB6 RID: 56502 RVA: 0x003D4AAE File Offset: 0x003D2CAE
		// (set) Token: 0x0600DCB7 RID: 56503 RVA: 0x003D4AB6 File Offset: 0x003D2CB6
		public int id { get; set; }

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x003D4ABF File Offset: 0x003D2CBF
		// (set) Token: 0x0600DCB9 RID: 56505 RVA: 0x003D4AC7 File Offset: 0x003D2CC7
		public int imagine { get; set; }

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x0600DCBA RID: 56506 RVA: 0x003D4AD0 File Offset: 0x003D2CD0
		// (set) Token: 0x0600DCBB RID: 56507 RVA: 0x003D4AD8 File Offset: 0x003D2CD8
		public int inspiration { get; set; }

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x0600DCBC RID: 56508 RVA: 0x003D4AE1 File Offset: 0x003D2CE1
		// (set) Token: 0x0600DCBD RID: 56509 RVA: 0x003D4AE9 File Offset: 0x003D2CE9
		public int observe { get; set; }

		// Token: 0x17001583 RID: 5507
		// (get) Token: 0x0600DCBE RID: 56510 RVA: 0x003D4AF2 File Offset: 0x003D2CF2
		// (set) Token: 0x0600DCBF RID: 56511 RVA: 0x003D4AFA File Offset: 0x003D2CFA
		public int obstaclesNum { get; set; }

		// Token: 0x17001584 RID: 5508
		// (get) Token: 0x0600DCC0 RID: 56512 RVA: 0x003D4B03 File Offset: 0x003D2D03
		// (set) Token: 0x0600DCC1 RID: 56513 RVA: 0x003D4B0B File Offset: 0x003D2D0B
		public int skill { get; set; }

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x0600DCC2 RID: 56514 RVA: 0x003D4B14 File Offset: 0x003D2D14
		// (set) Token: 0x0600DCC3 RID: 56515 RVA: 0x003D4B1C File Offset: 0x003D2D1C
		public int unlockTime { get; set; }

		// Token: 0x0600DCC4 RID: 56516 RVA: 0x003D4B28 File Offset: 0x003D2D28
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.difficulty = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.imagine = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.inspiration = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.observe = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.obstaclesNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.skill = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlockTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
