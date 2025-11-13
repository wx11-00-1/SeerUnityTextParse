using System;

namespace core.config.Wishpet
{
	// Token: 0x02001EED RID: 7917
	public class IWishpets
	{
		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x0600ED00 RID: 60672 RVA: 0x003F0C0A File Offset: 0x003EEE0A
		// (set) Token: 0x0600ED01 RID: 60673 RVA: 0x003F0C12 File Offset: 0x003EEE12
		public IWishpetItem[] Wishpet { get; set; }

		// Token: 0x0600ED02 RID: 60674 RVA: 0x003F0C1C File Offset: 0x003EEE1C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Wishpet = new IWishpetItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Wishpet[i] = new IWishpetItem();
					this.Wishpet[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
