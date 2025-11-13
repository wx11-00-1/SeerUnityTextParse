using System;

namespace core.config.product_diamond
{
	// Token: 0x02001F37 RID: 7991
	public class IRoot
	{
		// Token: 0x17001BD3 RID: 7123
		// (get) Token: 0x0600EFB6 RID: 61366 RVA: 0x003F3E9C File Offset: 0x003F209C
		// (set) Token: 0x0600EFB7 RID: 61367 RVA: 0x003F3EA4 File Offset: 0x003F20A4
		public IItemItem[] item { get; set; }

		// Token: 0x0600EFB8 RID: 61368 RVA: 0x003F3EB0 File Offset: 0x003F20B0
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
