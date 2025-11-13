using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F57 RID: 8023
	public class IPlaceItem
	{
		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x0600F0AE RID: 61614 RVA: 0x003F51B8 File Offset: 0x003F33B8
		// (set) Token: 0x0600F0AF RID: 61615 RVA: 0x003F51C0 File Offset: 0x003F33C0
		public string Desc { get; set; }

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x0600F0B0 RID: 61616 RVA: 0x003F51C9 File Offset: 0x003F33C9
		// (set) Token: 0x0600F0B1 RID: 61617 RVA: 0x003F51D1 File Offset: 0x003F33D1
		public string Go { get; set; }

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x0600F0B2 RID: 61618 RVA: 0x003F51DA File Offset: 0x003F33DA
		// (set) Token: 0x0600F0B3 RID: 61619 RVA: 0x003F51E2 File Offset: 0x003F33E2
		public string Redirect { get; set; }

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x0600F0B4 RID: 61620 RVA: 0x003F51EB File Offset: 0x003F33EB
		// (set) Token: 0x0600F0B5 RID: 61621 RVA: 0x003F51F3 File Offset: 0x003F33F3
		public int[] Mintmark { get; set; }

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x0600F0B6 RID: 61622 RVA: 0x003F51FC File Offset: 0x003F33FC
		// (set) Token: 0x0600F0B7 RID: 61623 RVA: 0x003F5204 File Offset: 0x003F3404
		public int ID { get; set; }

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x0600F0B8 RID: 61624 RVA: 0x003F520D File Offset: 0x003F340D
		// (set) Token: 0x0600F0B9 RID: 61625 RVA: 0x003F5215 File Offset: 0x003F3415
		public int ImageID { get; set; }

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x0600F0BA RID: 61626 RVA: 0x003F521E File Offset: 0x003F341E
		// (set) Token: 0x0600F0BB RID: 61627 RVA: 0x003F5226 File Offset: 0x003F3426
		public int Label { get; set; }

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x0600F0BC RID: 61628 RVA: 0x003F522F File Offset: 0x003F342F
		// (set) Token: 0x0600F0BD RID: 61629 RVA: 0x003F5237 File Offset: 0x003F3437
		public int monID { get; set; }

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x0600F0BE RID: 61630 RVA: 0x003F5240 File Offset: 0x003F3440
		// (set) Token: 0x0600F0BF RID: 61631 RVA: 0x003F5248 File Offset: 0x003F3448
		public int type { get; set; }

		// Token: 0x0600F0C0 RID: 61632 RVA: 0x003F5254 File Offset: 0x003F3454
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
			this.monID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
