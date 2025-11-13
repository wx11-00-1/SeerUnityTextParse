using System;

namespace core.config.open_bonus
{
	// Token: 0x02001F7F RID: 8063
	public class IOutItem
	{
		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x0600F1E4 RID: 61924 RVA: 0x003F6A13 File Offset: 0x003F4C13
		// (set) Token: 0x0600F1E5 RID: 61925 RVA: 0x003F6A1B File Offset: 0x003F4C1B
		public IMintmark Mintmark { get; set; }

		// Token: 0x0600F1E6 RID: 61926 RVA: 0x003F6A24 File Offset: 0x003F4C24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Mintmark = new IMintmark();
				this.Mintmark.Parse(bytes, ref byteIndex);
			}
		}
	}
}
