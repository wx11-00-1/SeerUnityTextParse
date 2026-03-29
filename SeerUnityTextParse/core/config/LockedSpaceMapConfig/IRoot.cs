using System;

namespace core.config.LockedSpaceMapConfig
{
	// Token: 0x02002580 RID: 9600
	public class IRoot
	{
		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x06012AB5 RID: 76469 RVA: 0x004BE038 File Offset: 0x004BC238
		// (set) Token: 0x06012AB6 RID: 76470 RVA: 0x004BE040 File Offset: 0x004BC240
		public IItemItem[] item { get; set; }

		// Token: 0x06012AB7 RID: 76471 RVA: 0x004BE04C File Offset: 0x004BC24C
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
