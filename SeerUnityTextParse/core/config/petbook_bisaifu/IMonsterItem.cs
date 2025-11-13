using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F60 RID: 8032
	public class IMonsterItem
	{
		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x0600F0F6 RID: 61686 RVA: 0x003F57DA File Offset: 0x003F39DA
		// (set) Token: 0x0600F0F7 RID: 61687 RVA: 0x003F57E2 File Offset: 0x003F39E2
		public string DefName { get; set; }

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x0600F0F8 RID: 61688 RVA: 0x003F57EB File Offset: 0x003F39EB
		// (set) Token: 0x0600F0F9 RID: 61689 RVA: 0x003F57F3 File Offset: 0x003F39F3
		public string Features { get; set; }

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x0600F0FA RID: 61690 RVA: 0x003F57FC File Offset: 0x003F39FC
		// (set) Token: 0x0600F0FB RID: 61691 RVA: 0x003F5804 File Offset: 0x003F3A04
		public string Target { get; set; }

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x0600F0FC RID: 61692 RVA: 0x003F580D File Offset: 0x003F3A0D
		// (set) Token: 0x0600F0FD RID: 61693 RVA: 0x003F5815 File Offset: 0x003F3A15
		public int ID { get; set; }

		// Token: 0x0600F0FE RID: 61694 RVA: 0x003F5820 File Offset: 0x003F3A20
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Features = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
