using System;

namespace core.config.open_bonus
{
	// Token: 0x02001F7E RID: 8062
	public class IMintmark
	{
		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x0600F1E0 RID: 61920 RVA: 0x003F69EB File Offset: 0x003F4BEB
		// (set) Token: 0x0600F1E1 RID: 61921 RVA: 0x003F69F3 File Offset: 0x003F4BF3
		public int ID { get; set; }

		// Token: 0x0600F1E2 RID: 61922 RVA: 0x003F69FC File Offset: 0x003F4BFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
