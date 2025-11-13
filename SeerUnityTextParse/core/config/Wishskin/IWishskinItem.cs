using System;

namespace core.config.Wishskin
{
	// Token: 0x02001EE9 RID: 7913
	public class IWishskinItem
	{
		// Token: 0x17001AB8 RID: 6840
		// (get) Token: 0x0600ECE4 RID: 60644 RVA: 0x003F0A58 File Offset: 0x003EEC58
		// (set) Token: 0x0600ECE5 RID: 60645 RVA: 0x003F0A60 File Offset: 0x003EEC60
		public int MonID { get; set; }

		// Token: 0x17001AB9 RID: 6841
		// (get) Token: 0x0600ECE6 RID: 60646 RVA: 0x003F0A69 File Offset: 0x003EEC69
		// (set) Token: 0x0600ECE7 RID: 60647 RVA: 0x003F0A71 File Offset: 0x003EEC71
		public int PetSkinID { get; set; }

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x0600ECE8 RID: 60648 RVA: 0x003F0A7A File Offset: 0x003EEC7A
		// (set) Token: 0x0600ECE9 RID: 60649 RVA: 0x003F0A82 File Offset: 0x003EEC82
		public int WishskinID { get; set; }

		// Token: 0x0600ECEA RID: 60650 RVA: 0x003F0A8B File Offset: 0x003EEC8B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.MonID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PetSkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.WishskinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
