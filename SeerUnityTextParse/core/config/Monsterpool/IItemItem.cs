using System;

namespace core.config.Monsterpool
{
	// Token: 0x02001FB9 RID: 8121
	public class IItemItem
	{
		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x0600F4B6 RID: 62646 RVA: 0x003F9F92 File Offset: 0x003F8192
		// (set) Token: 0x0600F4B7 RID: 62647 RVA: 0x003F9F9A File Offset: 0x003F819A
		public string monstername { get; set; }

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x0600F4B8 RID: 62648 RVA: 0x003F9FA3 File Offset: 0x003F81A3
		// (set) Token: 0x0600F4B9 RID: 62649 RVA: 0x003F9FAB File Offset: 0x003F81AB
		public int isjustone { get; set; }

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x0600F4BA RID: 62650 RVA: 0x003F9FB4 File Offset: 0x003F81B4
		// (set) Token: 0x0600F4BB RID: 62651 RVA: 0x003F9FBC File Offset: 0x003F81BC
		public int kind { get; set; }

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x0600F4BC RID: 62652 RVA: 0x003F9FC5 File Offset: 0x003F81C5
		// (set) Token: 0x0600F4BD RID: 62653 RVA: 0x003F9FCD File Offset: 0x003F81CD
		public int monsterid { get; set; }

		// Token: 0x0600F4BE RID: 62654 RVA: 0x003F9FD6 File Offset: 0x003F81D6
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.isjustone = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.kind = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monstername = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
