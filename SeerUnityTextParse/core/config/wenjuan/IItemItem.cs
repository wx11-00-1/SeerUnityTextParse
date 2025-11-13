using System;

namespace core.config.wenjuan
{
	// Token: 0x02001EF2 RID: 7922
	public class IItemItem
	{
		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x0600ED20 RID: 60704 RVA: 0x003F0E52 File Offset: 0x003EF052
		// (set) Token: 0x0600ED21 RID: 60705 RVA: 0x003F0E5A File Offset: 0x003EF05A
		public string a { get; set; }

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x0600ED22 RID: 60706 RVA: 0x003F0E63 File Offset: 0x003EF063
		// (set) Token: 0x0600ED23 RID: 60707 RVA: 0x003F0E6B File Offset: 0x003EF06B
		public int dir { get; set; }

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x0600ED24 RID: 60708 RVA: 0x003F0E74 File Offset: 0x003EF074
		// (set) Token: 0x0600ED25 RID: 60709 RVA: 0x003F0E7C File Offset: 0x003EF07C
		public int wb { get; set; }

		// Token: 0x0600ED26 RID: 60710 RVA: 0x003F0E85 File Offset: 0x003EF085
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.a = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.dir = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wb = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
