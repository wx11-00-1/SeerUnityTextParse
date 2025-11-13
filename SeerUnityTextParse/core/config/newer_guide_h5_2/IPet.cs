using System;

namespace core.config.newer_guide_h5_2
{
	// Token: 0x02001F93 RID: 8083
	public class IPet
	{
		// Token: 0x17001CEC RID: 7404
		// (get) Token: 0x0600F2A0 RID: 62112 RVA: 0x003F77F0 File Offset: 0x003F59F0
		// (set) Token: 0x0600F2A1 RID: 62113 RVA: 0x003F77F8 File Offset: 0x003F59F8
		public int petId { get; set; }

		// Token: 0x17001CED RID: 7405
		// (get) Token: 0x0600F2A2 RID: 62114 RVA: 0x003F7801 File Offset: 0x003F5A01
		// (set) Token: 0x0600F2A3 RID: 62115 RVA: 0x003F7809 File Offset: 0x003F5A09
		public int x { get; set; }

		// Token: 0x17001CEE RID: 7406
		// (get) Token: 0x0600F2A4 RID: 62116 RVA: 0x003F7812 File Offset: 0x003F5A12
		// (set) Token: 0x0600F2A5 RID: 62117 RVA: 0x003F781A File Offset: 0x003F5A1A
		public int y { get; set; }

		// Token: 0x0600F2A6 RID: 62118 RVA: 0x003F7823 File Offset: 0x003F5A23
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.petId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.x = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.y = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
