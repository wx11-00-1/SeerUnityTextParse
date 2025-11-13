using System;

namespace core.config.advancedPetPanelConfig
{
	// Token: 0x02002079 RID: 8313
	public class IFreeTime
	{
		// Token: 0x17002126 RID: 8486
		// (get) Token: 0x0600FDD1 RID: 64977 RVA: 0x004038A8 File Offset: 0x00401AA8
		// (set) Token: 0x0600FDD2 RID: 64978 RVA: 0x004038B0 File Offset: 0x00401AB0
		public int Id { get; set; }

		// Token: 0x0600FDD3 RID: 64979 RVA: 0x004038B9 File Offset: 0x00401AB9
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
