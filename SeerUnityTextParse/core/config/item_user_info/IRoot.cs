using System;

namespace core.config.item_user_info
{
	// Token: 0x02001FDC RID: 8156
	public class IRoot
	{
		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x0600F5D7 RID: 62935 RVA: 0x003FB53F File Offset: 0x003F973F
		// (set) Token: 0x0600F5D8 RID: 62936 RVA: 0x003FB547 File Offset: 0x003F9747
		public IItemItem[] item { get; set; }

		// Token: 0x0600F5D9 RID: 62937 RVA: 0x003FB550 File Offset: 0x003F9750
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
