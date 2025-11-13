using System;

namespace core.config.Wishpart
{
	// Token: 0x02001EEF RID: 7919
	public class IWishpartItem
	{
		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x0600ED0A RID: 60682 RVA: 0x003F0CD4 File Offset: 0x003EEED4
		// (set) Token: 0x0600ED0B RID: 60683 RVA: 0x003F0CDC File Offset: 0x003EEEDC
		public string PartItemName { get; set; }

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x0600ED0C RID: 60684 RVA: 0x003F0CE5 File Offset: 0x003EEEE5
		// (set) Token: 0x0600ED0D RID: 60685 RVA: 0x003F0CED File Offset: 0x003EEEED
		public string PartItemType { get; set; }

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x0600ED0E RID: 60686 RVA: 0x003F0CF6 File Offset: 0x003EEEF6
		// (set) Token: 0x0600ED0F RID: 60687 RVA: 0x003F0CFE File Offset: 0x003EEEFE
		public int PartItemID { get; set; }

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x0600ED10 RID: 60688 RVA: 0x003F0D07 File Offset: 0x003EEF07
		// (set) Token: 0x0600ED11 RID: 60689 RVA: 0x003F0D0F File Offset: 0x003EEF0F
		public int WishpartID { get; set; }

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x0600ED12 RID: 60690 RVA: 0x003F0D18 File Offset: 0x003EEF18
		// (set) Token: 0x0600ED13 RID: 60691 RVA: 0x003F0D20 File Offset: 0x003EEF20
		public int WishrankID { get; set; }

		// Token: 0x0600ED14 RID: 60692 RVA: 0x003F0D2C File Offset: 0x003EEF2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.PartItemID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.PartItemName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.PartItemType = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.WishpartID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.WishrankID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
