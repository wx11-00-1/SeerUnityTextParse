using System;

namespace core.config.petbook
{
	// Token: 0x02001F6A RID: 8042
	public class IItem
	{
		// Token: 0x17001C6C RID: 7276
		// (get) Token: 0x0600F14E RID: 61774 RVA: 0x003F5EE3 File Offset: 0x003F40E3
		// (set) Token: 0x0600F14F RID: 61775 RVA: 0x003F5EEB File Offset: 0x003F40EB
		public string intro { get; set; }

		// Token: 0x17001C6D RID: 7277
		// (get) Token: 0x0600F150 RID: 61776 RVA: 0x003F5EF4 File Offset: 0x003F40F4
		// (set) Token: 0x0600F151 RID: 61777 RVA: 0x003F5EFC File Offset: 0x003F40FC
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F152 RID: 61778 RVA: 0x003F5F08 File Offset: 0x003F4108
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.place = new IPlaceItem[num];
				for (int i = 0; i < num; i++)
				{
					this.place[i] = new IPlaceItem();
					this.place[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
