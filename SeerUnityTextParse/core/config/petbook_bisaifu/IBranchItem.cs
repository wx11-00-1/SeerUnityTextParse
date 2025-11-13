using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F5C RID: 8028
	public class IBranchItem
	{
		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x0600F0DC RID: 61660 RVA: 0x003F5573 File Offset: 0x003F3773
		// (set) Token: 0x0600F0DD RID: 61661 RVA: 0x003F557B File Offset: 0x003F377B
		public string intro { get; set; }

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x0600F0DE RID: 61662 RVA: 0x003F5584 File Offset: 0x003F3784
		// (set) Token: 0x0600F0DF RID: 61663 RVA: 0x003F558C File Offset: 0x003F378C
		public IPlaceItem[] place { get; set; }

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x0600F0E0 RID: 61664 RVA: 0x003F5595 File Offset: 0x003F3795
		// (set) Token: 0x0600F0E1 RID: 61665 RVA: 0x003F559D File Offset: 0x003F379D
		public string title { get; set; }

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x0600F0E2 RID: 61666 RVA: 0x003F55A6 File Offset: 0x003F37A6
		// (set) Token: 0x0600F0E3 RID: 61667 RVA: 0x003F55AE File Offset: 0x003F37AE
		public int ID { get; set; }

		// Token: 0x0600F0E4 RID: 61668 RVA: 0x003F55B8 File Offset: 0x003F37B8
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
