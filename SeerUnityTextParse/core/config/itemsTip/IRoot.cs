using System;

namespace core.config.itemsTip
{
	// Token: 0x02001FE3 RID: 8163
	public class IRoot
	{
		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x0600F5FB RID: 62971 RVA: 0x003FB7D1 File Offset: 0x003F99D1
		// (set) Token: 0x0600F5FC RID: 62972 RVA: 0x003FB7D9 File Offset: 0x003F99D9
		public IItemItem[] item { get; set; }

		// Token: 0x0600F5FD RID: 62973 RVA: 0x003FB7E4 File Offset: 0x003F99E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.item[i] = new IItemItem();
					this.item[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
