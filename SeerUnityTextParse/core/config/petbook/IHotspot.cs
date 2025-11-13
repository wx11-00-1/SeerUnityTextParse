using System;

namespace core.config.petbook
{
	// Token: 0x02001F69 RID: 8041
	public class IHotspot
	{
		// Token: 0x17001C6B RID: 7275
		// (get) Token: 0x0600F14A RID: 61770 RVA: 0x003F5EA7 File Offset: 0x003F40A7
		// (set) Token: 0x0600F14B RID: 61771 RVA: 0x003F5EAF File Offset: 0x003F40AF
		public IItem item { get; set; }

		// Token: 0x0600F14C RID: 61772 RVA: 0x003F5EB8 File Offset: 0x003F40B8
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
