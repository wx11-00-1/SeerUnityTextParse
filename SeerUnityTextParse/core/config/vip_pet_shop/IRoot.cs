using System;

namespace core.config.vip_pet_shop
{
	// Token: 0x02001EF8 RID: 7928
	public class IRoot
	{
		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x0600ED64 RID: 60772 RVA: 0x003F12CB File Offset: 0x003EF4CB
		// (set) Token: 0x0600ED65 RID: 60773 RVA: 0x003F12D3 File Offset: 0x003EF4D3
		public IPetItem[] Pet { get; set; }

		// Token: 0x0600ED66 RID: 60774 RVA: 0x003F12DC File Offset: 0x003EF4DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Pet = new IPetItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Pet[i] = new IPetItem();
					this.Pet[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
