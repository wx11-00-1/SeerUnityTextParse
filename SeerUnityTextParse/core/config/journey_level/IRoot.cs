using System;

namespace core.config.journey_level
{
	// Token: 0x02002583 RID: 9603
	public class IRoot
	{
		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x06012ACD RID: 76493 RVA: 0x004BE1EB File Offset: 0x004BC3EB
		// (set) Token: 0x06012ACE RID: 76494 RVA: 0x004BE1F3 File Offset: 0x004BC3F3
		public IItemItem[] item { get; set; }

		// Token: 0x06012ACF RID: 76495 RVA: 0x004BE1FC File Offset: 0x004BC3FC
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
