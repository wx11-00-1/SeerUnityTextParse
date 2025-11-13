using System;

namespace core.config.JackPotShop
{
	// Token: 0x02001FD7 RID: 8151
	public class IBlueChipShops
	{
		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x0600F5A5 RID: 62885 RVA: 0x003FB1F0 File Offset: 0x003F93F0
		// (set) Token: 0x0600F5A6 RID: 62886 RVA: 0x003FB1F8 File Offset: 0x003F93F8
		public IBulechipShopItem[] BulechipShop { get; set; }

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x0600F5A7 RID: 62887 RVA: 0x003FB201 File Offset: 0x003F9401
		// (set) Token: 0x0600F5A8 RID: 62888 RVA: 0x003FB209 File Offset: 0x003F9409
		public string Endday { get; set; }

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x0600F5A9 RID: 62889 RVA: 0x003FB212 File Offset: 0x003F9412
		// (set) Token: 0x0600F5AA RID: 62890 RVA: 0x003FB21A File Offset: 0x003F941A
		public string Endtime { get; set; }

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x0600F5AB RID: 62891 RVA: 0x003FB223 File Offset: 0x003F9423
		// (set) Token: 0x0600F5AC RID: 62892 RVA: 0x003FB22B File Offset: 0x003F942B
		public string Openday { get; set; }

		// Token: 0x0600F5AD RID: 62893 RVA: 0x003FB234 File Offset: 0x003F9434
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.BulechipShop = new IBulechipShopItem[num];
				for (int i = 0; i < num; i++)
				{
					this.BulechipShop[i] = new IBulechipShopItem();
					this.BulechipShop[i].Parse(bytes, ref byteIndex);
				}
			}
			this.Endday = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Endtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Openday = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
