using System;

namespace core.config.nature
{
	// Token: 0x02001F9C RID: 8092
	public class IRoot
	{
		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x0600F33A RID: 62266 RVA: 0x003F830F File Offset: 0x003F650F
		// (set) Token: 0x0600F33B RID: 62267 RVA: 0x003F8317 File Offset: 0x003F6517
		public IItemItem[] item { get; set; }

		// Token: 0x0600F33C RID: 62268 RVA: 0x003F8320 File Offset: 0x003F6520
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
