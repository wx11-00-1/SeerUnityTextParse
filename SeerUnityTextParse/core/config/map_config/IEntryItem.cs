using System;

namespace core.config.map_config
{
	// Token: 0x02001FD3 RID: 8147
	public class IEntryItem
	{
		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x0600F58F RID: 62863 RVA: 0x003FB062 File Offset: 0x003F9262
		// (set) Token: 0x0600F590 RID: 62864 RVA: 0x003FB06A File Offset: 0x003F926A
		public int FromMap { get; set; }

		// Token: 0x0600F591 RID: 62865 RVA: 0x003FB073 File Offset: 0x003F9273
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.FromMap = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
