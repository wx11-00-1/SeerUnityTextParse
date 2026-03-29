using System;

namespace core.config.mainLine_chapter
{
	// Token: 0x0200257A RID: 9594
	public class IRoot
	{
		// Token: 0x1700260F RID: 9743
		// (get) Token: 0x06012A6F RID: 76399 RVA: 0x004BDB83 File Offset: 0x004BBD83
		// (set) Token: 0x06012A70 RID: 76400 RVA: 0x004BDB8B File Offset: 0x004BBD8B
		public IItemItem[] item { get; set; }

		// Token: 0x06012A71 RID: 76401 RVA: 0x004BDB94 File Offset: 0x004BBD94
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
