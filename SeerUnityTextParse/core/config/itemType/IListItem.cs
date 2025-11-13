using System;

namespace core.config.itemType
{
	// Token: 0x02001FDF RID: 8159
	public class IListItem
	{
		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x0600F5E5 RID: 62949 RVA: 0x003FB630 File Offset: 0x003F9830
		// (set) Token: 0x0600F5E6 RID: 62950 RVA: 0x003FB638 File Offset: 0x003F9838
		public IItemItem[] Item { get; set; }

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x0600F5E7 RID: 62951 RVA: 0x003FB641 File Offset: 0x003F9841
		// (set) Token: 0x0600F5E8 RID: 62952 RVA: 0x003FB649 File Offset: 0x003F9849
		public int type { get; set; }

		// Token: 0x0600F5E9 RID: 62953 RVA: 0x003FB654 File Offset: 0x003F9854
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
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
