using System;

namespace core.config.skillTypes
{
	// Token: 0x02001F21 RID: 7969
	public class IRoot
	{
		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x0600EECC RID: 61132 RVA: 0x003F2D0A File Offset: 0x003F0F0A
		// (set) Token: 0x0600EECD RID: 61133 RVA: 0x003F2D12 File Offset: 0x003F0F12
		public IItemItem[] item { get; set; }

		// Token: 0x0600EECE RID: 61134 RVA: 0x003F2D1C File Offset: 0x003F0F1C
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
