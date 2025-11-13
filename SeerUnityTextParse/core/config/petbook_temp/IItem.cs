using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F54 RID: 8020
	public class IItem
	{
		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x0600F092 RID: 61586 RVA: 0x003F4FA3 File Offset: 0x003F31A3
		// (set) Token: 0x0600F093 RID: 61587 RVA: 0x003F4FAB File Offset: 0x003F31AB
		public string intro { get; set; }

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x0600F094 RID: 61588 RVA: 0x003F4FB4 File Offset: 0x003F31B4
		// (set) Token: 0x0600F095 RID: 61589 RVA: 0x003F4FBC File Offset: 0x003F31BC
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F096 RID: 61590 RVA: 0x003F4FC8 File Offset: 0x003F31C8
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
