using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F5E RID: 8030
	public class IHotspot
	{
		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x0600F0EC RID: 61676 RVA: 0x003F570B File Offset: 0x003F390B
		// (set) Token: 0x0600F0ED RID: 61677 RVA: 0x003F5713 File Offset: 0x003F3913
		public IItem item { get; set; }

		// Token: 0x0600F0EE RID: 61678 RVA: 0x003F571C File Offset: 0x003F391C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.item = new IItem();
				this.item.Parse(bytes, ref byteIndex);
			}
		}
	}
}
