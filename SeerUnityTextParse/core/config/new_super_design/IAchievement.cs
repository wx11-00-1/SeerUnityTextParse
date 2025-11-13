using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F83 RID: 8067
	public class IAchievement
	{
		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x0600F1F8 RID: 61944 RVA: 0x003F6BA4 File Offset: 0x003F4DA4
		// (set) Token: 0x0600F1F9 RID: 61945 RVA: 0x003F6BAC File Offset: 0x003F4DAC
		public int BranchID { get; set; }

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x0600F1FA RID: 61946 RVA: 0x003F6BB5 File Offset: 0x003F4DB5
		// (set) Token: 0x0600F1FB RID: 61947 RVA: 0x003F6BBD File Offset: 0x003F4DBD
		public int RuleID { get; set; }

		// Token: 0x0600F1FC RID: 61948 RVA: 0x003F6BC6 File Offset: 0x003F4DC6
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BranchID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.RuleID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
