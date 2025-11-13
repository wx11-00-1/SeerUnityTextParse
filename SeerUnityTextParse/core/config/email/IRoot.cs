using System;

namespace core.config.email
{
	// Token: 0x02002049 RID: 8265
	public class IRoot
	{
		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x0600FC63 RID: 64611 RVA: 0x00401D9E File Offset: 0x003FFF9E
		// (set) Token: 0x0600FC64 RID: 64612 RVA: 0x00401DA6 File Offset: 0x003FFFA6
		public IElements elements { get; set; }

		// Token: 0x0600FC65 RID: 64613 RVA: 0x00401DAF File Offset: 0x003FFFAF
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.elements = new IElements();
				this.elements.Parse(bytes, ref byteIndex);
			}
		}
	}
}
