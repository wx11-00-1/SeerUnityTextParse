using System;

namespace core.config.monsters
{
	// Token: 0x02001FB8 RID: 8120
	public class ISpMoveItem
	{
		// Token: 0x17001DCD RID: 7629
		// (get) Token: 0x0600F4AC RID: 62636 RVA: 0x003F9F10 File Offset: 0x003F8110
		// (set) Token: 0x0600F4AD RID: 62637 RVA: 0x003F9F18 File Offset: 0x003F8118
		public int ID { get; set; }

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x0600F4AE RID: 62638 RVA: 0x003F9F21 File Offset: 0x003F8121
		// (set) Token: 0x0600F4AF RID: 62639 RVA: 0x003F9F29 File Offset: 0x003F8129
		public int Rec { get; set; }

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x0600F4B0 RID: 62640 RVA: 0x003F9F32 File Offset: 0x003F8132
		// (set) Token: 0x0600F4B1 RID: 62641 RVA: 0x003F9F3A File Offset: 0x003F813A
		public int tag { get; set; }

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x0600F4B2 RID: 62642 RVA: 0x003F9F43 File Offset: 0x003F8143
		// (set) Token: 0x0600F4B3 RID: 62643 RVA: 0x003F9F4B File Offset: 0x003F814B
		public int Tag { get; set; }

		// Token: 0x0600F4B4 RID: 62644 RVA: 0x003F9F54 File Offset: 0x003F8154
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rec = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tag = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
