using System;

namespace core.config.suit
{
	// Token: 0x02001F13 RID: 7955
	public class IRoot
	{
		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x0600EE3C RID: 60988 RVA: 0x003F22CC File Offset: 0x003F04CC
		// (set) Token: 0x0600EE3D RID: 60989 RVA: 0x003F22D4 File Offset: 0x003F04D4
		public IItemItem[] item { get; set; }

		// Token: 0x0600EE3E RID: 60990 RVA: 0x003F22E0 File Offset: 0x003F04E0
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
