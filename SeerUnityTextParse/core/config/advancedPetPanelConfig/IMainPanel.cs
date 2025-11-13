using System;

namespace core.config.advancedPetPanelConfig
{
	// Token: 0x0200207A RID: 8314
	public class IMainPanel
	{
		// Token: 0x17002127 RID: 8487
		// (get) Token: 0x0600FDD5 RID: 64981 RVA: 0x004038D0 File Offset: 0x00401AD0
		// (set) Token: 0x0600FDD6 RID: 64982 RVA: 0x004038D8 File Offset: 0x00401AD8
		public IFreeTime FreeTime { get; set; }

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x0600FDD7 RID: 64983 RVA: 0x004038E1 File Offset: 0x00401AE1
		// (set) Token: 0x0600FDD8 RID: 64984 RVA: 0x004038E9 File Offset: 0x00401AE9
		public IFreeTime PayTime { get; set; }

		// Token: 0x0600FDD9 RID: 64985 RVA: 0x004038F4 File Offset: 0x00401AF4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.FreeTime = new IFreeTime();
				this.FreeTime.Parse(bytes, ref byteIndex);
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.PayTime = new IFreeTime();
				this.PayTime.Parse(bytes, ref byteIndex);
			}
		}
	}
}
