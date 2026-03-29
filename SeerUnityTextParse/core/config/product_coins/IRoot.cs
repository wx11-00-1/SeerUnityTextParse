using System;

namespace core.config.product_coins
{
	// Token: 0x020024BF RID: 9407
	public class IRoot
	{
		// Token: 0x17002346 RID: 9030
		// (get) Token: 0x06012362 RID: 74594 RVA: 0x004B4501 File Offset: 0x004B2701
		// (set) Token: 0x06012363 RID: 74595 RVA: 0x004B4509 File Offset: 0x004B2709
		public IItemItem[] item { get; set; }

		// Token: 0x06012364 RID: 74596 RVA: 0x004B4514 File Offset: 0x004B2714
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
