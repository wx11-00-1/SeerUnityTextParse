using System;

namespace core.config.product_money
{
	// Token: 0x02001F34 RID: 7988
	public class IRoot
	{
		// Token: 0x17001BCA RID: 7114
		// (get) Token: 0x0600EF9E RID: 61342 RVA: 0x003F3CCD File Offset: 0x003F1ECD
		// (set) Token: 0x0600EF9F RID: 61343 RVA: 0x003F3CD5 File Offset: 0x003F1ED5
		public IItemItem[] item { get; set; }

		// Token: 0x0600EFA0 RID: 61344 RVA: 0x003F3CE0 File Offset: 0x003F1EE0
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
