using System;

namespace core.config.Wishsuit
{
	// Token: 0x02001EE7 RID: 7911
	public class IWishsuits
	{
		// Token: 0x17001AB5 RID: 6837
		// (get) Token: 0x0600ECDA RID: 60634 RVA: 0x003F098D File Offset: 0x003EEB8D
		// (set) Token: 0x0600ECDB RID: 60635 RVA: 0x003F0995 File Offset: 0x003EEB95
		public IWishsuitItem[] Wishsuit { get; set; }

		// Token: 0x0600ECDC RID: 60636 RVA: 0x003F09A0 File Offset: 0x003EEBA0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Wishsuit = new IWishsuitItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Wishsuit[i] = new IWishsuitItem();
					this.Wishsuit[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
