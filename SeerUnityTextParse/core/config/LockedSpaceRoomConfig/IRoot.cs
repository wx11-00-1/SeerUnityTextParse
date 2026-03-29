using System;

namespace core.config.LockedSpaceRoomConfig
{
	// Token: 0x0200257D RID: 9597
	public class IRoot
	{
		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x06012A8F RID: 76431 RVA: 0x004BDDA4 File Offset: 0x004BBFA4
		// (set) Token: 0x06012A90 RID: 76432 RVA: 0x004BDDAC File Offset: 0x004BBFAC
		public IItemItem[] item { get; set; }

		// Token: 0x06012A91 RID: 76433 RVA: 0x004BDDB8 File Offset: 0x004BBFB8
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
