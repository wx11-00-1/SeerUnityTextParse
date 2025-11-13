using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F62 RID: 8034
	public class IPlaceItem
	{
		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x0600F10A RID: 61706 RVA: 0x003F5938 File Offset: 0x003F3B38
		// (set) Token: 0x0600F10B RID: 61707 RVA: 0x003F5940 File Offset: 0x003F3B40
		public string Desc { get; set; }

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x0600F10C RID: 61708 RVA: 0x003F5949 File Offset: 0x003F3B49
		// (set) Token: 0x0600F10D RID: 61709 RVA: 0x003F5951 File Offset: 0x003F3B51
		public string Go { get; set; }

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x0600F10E RID: 61710 RVA: 0x003F595A File Offset: 0x003F3B5A
		// (set) Token: 0x0600F10F RID: 61711 RVA: 0x003F5962 File Offset: 0x003F3B62
		public string Redirect { get; set; }

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x0600F110 RID: 61712 RVA: 0x003F596B File Offset: 0x003F3B6B
		// (set) Token: 0x0600F111 RID: 61713 RVA: 0x003F5973 File Offset: 0x003F3B73
		public int[] Mintmark { get; set; }

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x0600F112 RID: 61714 RVA: 0x003F597C File Offset: 0x003F3B7C
		// (set) Token: 0x0600F113 RID: 61715 RVA: 0x003F5984 File Offset: 0x003F3B84
		public int ID { get; set; }

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x0600F114 RID: 61716 RVA: 0x003F598D File Offset: 0x003F3B8D
		// (set) Token: 0x0600F115 RID: 61717 RVA: 0x003F5995 File Offset: 0x003F3B95
		public int ImageID { get; set; }

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x0600F116 RID: 61718 RVA: 0x003F599E File Offset: 0x003F3B9E
		// (set) Token: 0x0600F117 RID: 61719 RVA: 0x003F59A6 File Offset: 0x003F3BA6
		public int Label { get; set; }

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x0600F118 RID: 61720 RVA: 0x003F59AF File Offset: 0x003F3BAF
		// (set) Token: 0x0600F119 RID: 61721 RVA: 0x003F59B7 File Offset: 0x003F3BB7
		public int momID { get; set; }

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x0600F11A RID: 61722 RVA: 0x003F59C0 File Offset: 0x003F3BC0
		// (set) Token: 0x0600F11B RID: 61723 RVA: 0x003F59C8 File Offset: 0x003F3BC8
		public int monID { get; set; }

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x0600F11C RID: 61724 RVA: 0x003F59D1 File Offset: 0x003F3BD1
		// (set) Token: 0x0600F11D RID: 61725 RVA: 0x003F59D9 File Offset: 0x003F3BD9
		public int type { get; set; }

		// Token: 0x0600F11E RID: 61726 RVA: 0x003F59E4 File Offset: 0x003F3BE4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Go = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ImageID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Label = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Mintmark = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.Mintmark[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.Redirect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.momID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
