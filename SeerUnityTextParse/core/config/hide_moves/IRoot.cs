using System;

namespace core.config.hide_moves
{
	// Token: 0x02002029 RID: 8233
	public class IRoot
	{
		// Token: 0x17002041 RID: 8257
		// (get) Token: 0x0600FB67 RID: 64359 RVA: 0x00400B7B File Offset: 0x003FED7B
		// (set) Token: 0x0600FB68 RID: 64360 RVA: 0x00400B83 File Offset: 0x003FED83
		public IItemItem[] item { get; set; }

		// Token: 0x0600FB69 RID: 64361 RVA: 0x00400B8C File Offset: 0x003FED8C
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
