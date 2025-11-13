using System;

namespace core.config.awakendetail
{
	// Token: 0x02002069 RID: 8297
	public class IExMove
	{
		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x0600FD69 RID: 64873 RVA: 0x0040314B File Offset: 0x0040134B
		// (set) Token: 0x0600FD6A RID: 64874 RVA: 0x00403153 File Offset: 0x00401353
		public int ExtraMoves { get; set; }

		// Token: 0x0600FD6B RID: 64875 RVA: 0x0040315C File Offset: 0x0040135C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ExtraMoves = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
