using System;

namespace core.config.awakendetail
{
	// Token: 0x02002067 RID: 8295
	public class IAdvEffect
	{
		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x0600FD55 RID: 64853 RVA: 0x00402FE3 File Offset: 0x004011E3
		// (set) Token: 0x0600FD56 RID: 64854 RVA: 0x00402FEB File Offset: 0x004011EB
		public string Des { get; set; }

		// Token: 0x170020FB RID: 8443
		// (get) Token: 0x0600FD57 RID: 64855 RVA: 0x00402FF4 File Offset: 0x004011F4
		// (set) Token: 0x0600FD58 RID: 64856 RVA: 0x00402FFC File Offset: 0x004011FC
		public int Id { get; set; }

		// Token: 0x0600FD59 RID: 64857 RVA: 0x00403005 File Offset: 0x00401205
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
