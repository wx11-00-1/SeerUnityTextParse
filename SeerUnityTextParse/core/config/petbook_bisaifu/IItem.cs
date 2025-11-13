using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F5F RID: 8031
	public class IItem
	{
		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x0600F0F0 RID: 61680 RVA: 0x003F5747 File Offset: 0x003F3947
		// (set) Token: 0x0600F0F1 RID: 61681 RVA: 0x003F574F File Offset: 0x003F394F
		public string intro { get; set; }

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x0600F0F2 RID: 61682 RVA: 0x003F5758 File Offset: 0x003F3958
		// (set) Token: 0x0600F0F3 RID: 61683 RVA: 0x003F5760 File Offset: 0x003F3960
		public IPlaceItem[] place { get; set; }

		// Token: 0x0600F0F4 RID: 61684 RVA: 0x003F576C File Offset: 0x003F396C
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
