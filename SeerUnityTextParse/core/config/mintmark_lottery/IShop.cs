using System;

namespace core.config.mintmark_lottery
{
	// Token: 0x02001FC1 RID: 8129
	public class IShop
	{
		// Token: 0x17001DE7 RID: 7655
		// (get) Token: 0x0600F4F2 RID: 62706 RVA: 0x003FA3E8 File Offset: 0x003F85E8
		// (set) Token: 0x0600F4F3 RID: 62707 RVA: 0x003FA3F0 File Offset: 0x003F85F0
		public IMintMarkItem[] MintMark { get; set; }

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x0600F4F4 RID: 62708 RVA: 0x003FA3F9 File Offset: 0x003F85F9
		// (set) Token: 0x0600F4F5 RID: 62709 RVA: 0x003FA401 File Offset: 0x003F8601
		public string name { get; set; }

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x0600F4F6 RID: 62710 RVA: 0x003FA40A File Offset: 0x003F860A
		// (set) Token: 0x0600F4F7 RID: 62711 RVA: 0x003FA412 File Offset: 0x003F8612
		public int num { get; set; }

		// Token: 0x0600F4F8 RID: 62712 RVA: 0x003FA41C File Offset: 0x003F861C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.MintMark = new IMintMarkItem[num];
				for (int i = 0; i < num; i++)
				{
					this.MintMark[i] = new IMintMarkItem();
					this.MintMark[i].Parse(bytes, ref byteIndex);
				}
			}
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
