using System;

namespace core.config.figure_reward
{
	// Token: 0x02002036 RID: 8246
	public class IAch
	{
		// Token: 0x17002069 RID: 8297
		// (get) Token: 0x0600FBD1 RID: 64465 RVA: 0x004012D8 File Offset: 0x003FF4D8
		// (set) Token: 0x0600FBD2 RID: 64466 RVA: 0x004012E0 File Offset: 0x003FF4E0
		public int BranchID { get; set; }

		// Token: 0x1700206A RID: 8298
		// (get) Token: 0x0600FBD3 RID: 64467 RVA: 0x004012E9 File Offset: 0x003FF4E9
		// (set) Token: 0x0600FBD4 RID: 64468 RVA: 0x004012F1 File Offset: 0x003FF4F1
		public int RuleID { get; set; }

		// Token: 0x0600FBD5 RID: 64469 RVA: 0x004012FA File Offset: 0x003FF4FA
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BranchID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RuleID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
