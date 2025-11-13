using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F53 RID: 8019
	public class IHotspot
	{
		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x0600F08E RID: 61582 RVA: 0x003F4F67 File Offset: 0x003F3167
		// (set) Token: 0x0600F08F RID: 61583 RVA: 0x003F4F6F File Offset: 0x003F316F
		public IItem item { get; set; }

		// Token: 0x0600F090 RID: 61584 RVA: 0x003F4F78 File Offset: 0x003F3178
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
