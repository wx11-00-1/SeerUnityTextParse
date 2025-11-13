using System;

namespace core.config.monsters
{
	// Token: 0x02001FB6 RID: 8118
	public class IMoveItem
	{
		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x0600F49C RID: 62620 RVA: 0x003F9E32 File Offset: 0x003F8032
		// (set) Token: 0x0600F49D RID: 62621 RVA: 0x003F9E3A File Offset: 0x003F803A
		public int ID { get; set; }

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x0600F49E RID: 62622 RVA: 0x003F9E43 File Offset: 0x003F8043
		// (set) Token: 0x0600F49F RID: 62623 RVA: 0x003F9E4B File Offset: 0x003F804B
		public int LearningLv { get; set; }

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x0600F4A0 RID: 62624 RVA: 0x003F9E54 File Offset: 0x003F8054
		// (set) Token: 0x0600F4A1 RID: 62625 RVA: 0x003F9E5C File Offset: 0x003F805C
		public int Rec { get; set; }

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x0600F4A2 RID: 62626 RVA: 0x003F9E65 File Offset: 0x003F8065
		// (set) Token: 0x0600F4A3 RID: 62627 RVA: 0x003F9E6D File Offset: 0x003F806D
		public int Tag { get; set; }

		// Token: 0x0600F4A4 RID: 62628 RVA: 0x003F9E76 File Offset: 0x003F8076
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LearningLv = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
