using System;

namespace core.config.JackPotShop
{
	// Token: 0x02001FD9 RID: 8153
	public class IRoot
	{
		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x0600F5C5 RID: 62917 RVA: 0x003FB43D File Offset: 0x003F963D
		// (set) Token: 0x0600F5C6 RID: 62918 RVA: 0x003FB445 File Offset: 0x003F9645
		public IBlueChipShops BlueChipShops { get; set; }

		// Token: 0x0600F5C7 RID: 62919 RVA: 0x003FB44E File Offset: 0x003F964E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.BlueChipShops = new IBlueChipShops();
				this.BlueChipShops.Parse(bytes, ref byteIndex);
			}
		}
	}
}
