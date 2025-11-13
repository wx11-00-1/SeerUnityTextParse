using System;

namespace core.config.mintmark_lottery
{
	// Token: 0x02001FBF RID: 8127
	public class IMintmarks
	{
		// Token: 0x17001DE3 RID: 7651
		// (get) Token: 0x0600F4E6 RID: 62694 RVA: 0x003FA2EB File Offset: 0x003F84EB
		// (set) Token: 0x0600F4E7 RID: 62695 RVA: 0x003FA2F3 File Offset: 0x003F84F3
		public IMenuItem[] Menu { get; set; }

		// Token: 0x17001DE4 RID: 7652
		// (get) Token: 0x0600F4E8 RID: 62696 RVA: 0x003FA2FC File Offset: 0x003F84FC
		// (set) Token: 0x0600F4E9 RID: 62697 RVA: 0x003FA304 File Offset: 0x003F8504
		public IShop Shop { get; set; }

		// Token: 0x0600F4EA RID: 62698 RVA: 0x003FA310 File Offset: 0x003F8510
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Menu = new IMenuItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Menu[i] = new IMenuItem();
					this.Menu[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Shop = new IShop();
				this.Shop.Parse(bytes, ref byteIndex);
			}
		}
	}
}
