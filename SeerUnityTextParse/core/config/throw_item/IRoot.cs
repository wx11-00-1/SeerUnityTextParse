using System;

namespace core.config.throw_item
{
	// Token: 0x02001F10 RID: 7952
	public class IRoot
	{
		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x0600EE24 RID: 60964 RVA: 0x003F20FC File Offset: 0x003F02FC
		// (set) Token: 0x0600EE25 RID: 60965 RVA: 0x003F2104 File Offset: 0x003F0304
		public IItemItem[] item { get; set; }

		// Token: 0x0600EE26 RID: 60966 RVA: 0x003F2110 File Offset: 0x003F0310
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
