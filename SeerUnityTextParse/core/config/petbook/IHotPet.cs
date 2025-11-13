using System;

namespace core.config.petbook
{
	// Token: 0x02001F68 RID: 8040
	public class IHotPet
	{
		// Token: 0x17001C69 RID: 7273
		// (get) Token: 0x0600F144 RID: 61764 RVA: 0x003F5DE3 File Offset: 0x003F3FE3
		// (set) Token: 0x0600F145 RID: 61765 RVA: 0x003F5DEB File Offset: 0x003F3FEB
		public IPetDataItem[] PetData { get; set; }

		// Token: 0x17001C6A RID: 7274
		// (get) Token: 0x0600F146 RID: 61766 RVA: 0x003F5DF4 File Offset: 0x003F3FF4
		// (set) Token: 0x0600F147 RID: 61767 RVA: 0x003F5DFC File Offset: 0x003F3FFC
		public ITypeItem[] type { get; set; }

		// Token: 0x0600F148 RID: 61768 RVA: 0x003F5E08 File Offset: 0x003F4008
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.PetData = new IPetDataItem[num];
				for (int i = 0; i < num; i++)
				{
					this.PetData[i] = new IPetDataItem();
					this.PetData[i].Parse(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.type = new ITypeItem[num2];
				for (int j = 0; j < num2; j++)
				{
					this.type[j] = new ITypeItem();
					this.type[j].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
