using System;

namespace core.config.vip_item_shop
{
	// Token: 0x02001EFE RID: 7934
	public class IRoot
	{
		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x0600EDA2 RID: 60834 RVA: 0x003F174D File Offset: 0x003EF94D
		// (set) Token: 0x0600EDA3 RID: 60835 RVA: 0x003F1755 File Offset: 0x003EF955
		public IItemItem[] Item { get; set; }

		// Token: 0x0600EDA4 RID: 60836 RVA: 0x003F1760 File Offset: 0x003EF960
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Item[i] = new IItemItem();
					this.Item[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
