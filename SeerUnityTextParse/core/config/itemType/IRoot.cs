using System;

namespace core.config.itemType
{
	// Token: 0x02001FE0 RID: 8160
	public class IRoot
	{
		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x0600F5EB RID: 62955 RVA: 0x003FB6BB File Offset: 0x003F98BB
		// (set) Token: 0x0600F5EC RID: 62956 RVA: 0x003FB6C3 File Offset: 0x003F98C3
		public IListItem[] list { get; set; }

		// Token: 0x0600F5ED RID: 62957 RVA: 0x003FB6CC File Offset: 0x003F98CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.list = new IListItem[num];
				for (int i = 0; i < num; i++)
				{
					this.list[i] = new IListItem();
					this.list[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
