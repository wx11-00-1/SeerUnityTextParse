using System;

namespace core.config.pet_advance
{
	// Token: 0x02001F46 RID: 8006
	public class IExMove
	{
		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x0600F030 RID: 61488 RVA: 0x003F47E3 File Offset: 0x003F29E3
		// (set) Token: 0x0600F031 RID: 61489 RVA: 0x003F47EB File Offset: 0x003F29EB
		public int ExtraMoves { get; set; }

		// Token: 0x0600F032 RID: 61490 RVA: 0x003F47F4 File Offset: 0x003F29F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExtraMoves = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
