using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F5D RID: 8029
	public class IHotPet
	{
		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x0600F0E6 RID: 61670 RVA: 0x003F5647 File Offset: 0x003F3847
		// (set) Token: 0x0600F0E7 RID: 61671 RVA: 0x003F564F File Offset: 0x003F384F
		public IPetDataItem[] PetData { get; set; }

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x0600F0E8 RID: 61672 RVA: 0x003F5658 File Offset: 0x003F3858
		// (set) Token: 0x0600F0E9 RID: 61673 RVA: 0x003F5660 File Offset: 0x003F3860
		public ITypeItem[] type { get; set; }

		// Token: 0x0600F0EA RID: 61674 RVA: 0x003F566C File Offset: 0x003F386C
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
