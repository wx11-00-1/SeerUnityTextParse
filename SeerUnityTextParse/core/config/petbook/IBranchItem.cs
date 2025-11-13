using System;

namespace core.config.petbook
{
	// Token: 0x02001F67 RID: 8039
	public class IBranchItem
	{
		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x0600F13A RID: 61754 RVA: 0x003F5D0F File Offset: 0x003F3F0F
		// (set) Token: 0x0600F13B RID: 61755 RVA: 0x003F5D17 File Offset: 0x003F3F17
		public string intro { get; set; }

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x0600F13C RID: 61756 RVA: 0x003F5D20 File Offset: 0x003F3F20
		// (set) Token: 0x0600F13D RID: 61757 RVA: 0x003F5D28 File Offset: 0x003F3F28
		public IPlaceItem[] place { get; set; }

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x0600F13E RID: 61758 RVA: 0x003F5D31 File Offset: 0x003F3F31
		// (set) Token: 0x0600F13F RID: 61759 RVA: 0x003F5D39 File Offset: 0x003F3F39
		public string title { get; set; }

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x0600F140 RID: 61760 RVA: 0x003F5D42 File Offset: 0x003F3F42
		// (set) Token: 0x0600F141 RID: 61761 RVA: 0x003F5D4A File Offset: 0x003F3F4A
		public int ID { get; set; }

		// Token: 0x0600F142 RID: 61762 RVA: 0x003F5D54 File Offset: 0x003F3F54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
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
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
