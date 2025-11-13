using System;

namespace core.config.shop_config
{
	// Token: 0x02001F28 RID: 7976
	public class IRoot
	{
		// Token: 0x17001BA9 RID: 7081
		// (get) Token: 0x0600EF44 RID: 61252 RVA: 0x003F365D File Offset: 0x003F185D
		// (set) Token: 0x0600EF45 RID: 61253 RVA: 0x003F3665 File Offset: 0x003F1865
		public IMenuItem[] menu { get; set; }

		// Token: 0x0600EF46 RID: 61254 RVA: 0x003F3670 File Offset: 0x003F1870
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.menu = new IMenuItem[num];
				for (int i = 0; i < num; i++)
				{
					this.menu[i] = new IMenuItem();
					this.menu[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
