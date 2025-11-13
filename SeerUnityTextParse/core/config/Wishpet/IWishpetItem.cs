using System;

namespace core.config.Wishpet
{
	// Token: 0x02001EEC RID: 7916
	public class IWishpetItem
	{
		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x0600ECF6 RID: 60662 RVA: 0x003F0B88 File Offset: 0x003EED88
		// (set) Token: 0x0600ECF7 RID: 60663 RVA: 0x003F0B90 File Offset: 0x003EED90
		public int MonsterID { get; set; }

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x0600ECF8 RID: 60664 RVA: 0x003F0B99 File Offset: 0x003EED99
		// (set) Token: 0x0600ECF9 RID: 60665 RVA: 0x003F0BA1 File Offset: 0x003EEDA1
		public int MonsterStar { get; set; }

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x0600ECFA RID: 60666 RVA: 0x003F0BAA File Offset: 0x003EEDAA
		// (set) Token: 0x0600ECFB RID: 60667 RVA: 0x003F0BB2 File Offset: 0x003EEDB2
		public int WishpetID { get; set; }

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x0600ECFC RID: 60668 RVA: 0x003F0BBB File Offset: 0x003EEDBB
		// (set) Token: 0x0600ECFD RID: 60669 RVA: 0x003F0BC3 File Offset: 0x003EEDC3
		public int WishProgress { get; set; }

		// Token: 0x0600ECFE RID: 60670 RVA: 0x003F0BCC File Offset: 0x003EEDCC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.MonsterID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.MonsterStar = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.WishProgress = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.WishpetID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
