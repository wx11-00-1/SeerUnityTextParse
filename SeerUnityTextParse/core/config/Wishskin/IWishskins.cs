using System;

namespace core.config.Wishskin
{
	// Token: 0x02001EEA RID: 7914
	public class IWishskins
	{
		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x0600ECEC RID: 60652 RVA: 0x003F0ABC File Offset: 0x003EECBC
		// (set) Token: 0x0600ECED RID: 60653 RVA: 0x003F0AC4 File Offset: 0x003EECC4
		public IWishskinItem[] Wishskin { get; set; }

		// Token: 0x0600ECEE RID: 60654 RVA: 0x003F0AD0 File Offset: 0x003EECD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Wishskin = new IWishskinItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Wishskin[i] = new IWishskinItem();
					this.Wishskin[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
