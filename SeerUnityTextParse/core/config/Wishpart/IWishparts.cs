using System;

namespace core.config.Wishpart
{
	// Token: 0x02001EF0 RID: 7920
	public class IWishparts
	{
		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x0600ED16 RID: 60694 RVA: 0x003F0D90 File Offset: 0x003EEF90
		// (set) Token: 0x0600ED17 RID: 60695 RVA: 0x003F0D98 File Offset: 0x003EEF98
		public IWishpartItem[] Wishpart { get; set; }

		// Token: 0x0600ED18 RID: 60696 RVA: 0x003F0DA4 File Offset: 0x003EEFA4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Wishpart = new IWishpartItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Wishpart[i] = new IWishpartItem();
					this.Wishpart[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
