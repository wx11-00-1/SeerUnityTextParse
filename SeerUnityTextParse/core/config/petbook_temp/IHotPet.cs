using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F52 RID: 8018
	public class IHotPet
	{
		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x0600F088 RID: 61576 RVA: 0x003F4EA3 File Offset: 0x003F30A3
		// (set) Token: 0x0600F089 RID: 61577 RVA: 0x003F4EAB File Offset: 0x003F30AB
		public IPetDataItem[] PetData { get; set; }

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x0600F08A RID: 61578 RVA: 0x003F4EB4 File Offset: 0x003F30B4
		// (set) Token: 0x0600F08B RID: 61579 RVA: 0x003F4EBC File Offset: 0x003F30BC
		public ITypeItem[] type { get; set; }

		// Token: 0x0600F08C RID: 61580 RVA: 0x003F4EC8 File Offset: 0x003F30C8
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
