using System;

namespace core.config.redbutton
{
	// Token: 0x020024B0 RID: 9392
	public class IRedItem
	{
		// Token: 0x1700231A RID: 8986
		// (get) Token: 0x060122EC RID: 74476 RVA: 0x004B3BB8 File Offset: 0x004B1DB8
		// (set) Token: 0x060122ED RID: 74477 RVA: 0x004B3BC0 File Offset: 0x004B1DC0
		public int forwhat { get; set; }

		// Token: 0x1700231B RID: 8987
		// (get) Token: 0x060122EE RID: 74478 RVA: 0x004B3BC9 File Offset: 0x004B1DC9
		// (set) Token: 0x060122EF RID: 74479 RVA: 0x004B3BD1 File Offset: 0x004B1DD1
		public int ID { get; set; }

		// Token: 0x060122F0 RID: 74480 RVA: 0x004B3BDA File Offset: 0x004B1DDA
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.forwhat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
