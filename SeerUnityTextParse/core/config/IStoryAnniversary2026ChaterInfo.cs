using System;

namespace core.config
{
	// Token: 0x020026B9 RID: 9913
	public class IStoryAnniversary2026ChaterInfo : IConfigItem
	{
		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x060134B6 RID: 79030 RVA: 0x005231D0 File Offset: 0x005213D0
		// (set) Token: 0x060134B7 RID: 79031 RVA: 0x005231D8 File Offset: 0x005213D8
		public string half { get; set; }

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x060134B8 RID: 79032 RVA: 0x005231E1 File Offset: 0x005213E1
		// (set) Token: 0x060134B9 RID: 79033 RVA: 0x005231E9 File Offset: 0x005213E9
		public string head { get; set; }

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x060134BA RID: 79034 RVA: 0x005231F2 File Offset: 0x005213F2
		// (set) Token: 0x060134BB RID: 79035 RVA: 0x005231FA File Offset: 0x005213FA
		public string nickname { get; set; }

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x060134BC RID: 79036 RVA: 0x00523203 File Offset: 0x00521403
		// (set) Token: 0x060134BD RID: 79037 RVA: 0x0052320B File Offset: 0x0052140B
		public string signature { get; set; }

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x060134BE RID: 79038 RVA: 0x00523214 File Offset: 0x00521414
		// (set) Token: 0x060134BF RID: 79039 RVA: 0x0052321C File Offset: 0x0052141C
		public string trueName { get; set; }

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x060134C0 RID: 79040 RVA: 0x00523225 File Offset: 0x00521425
		// (set) Token: 0x060134C1 RID: 79041 RVA: 0x0052322D File Offset: 0x0052142D
		public int id { get; set; }

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x060134C2 RID: 79042 RVA: 0x00523236 File Offset: 0x00521436
		// (set) Token: 0x060134C3 RID: 79043 RVA: 0x0052323E File Offset: 0x0052143E
		public int userinfo { get; set; }

		// Token: 0x060134C4 RID: 79044 RVA: 0x00523248 File Offset: 0x00521448
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.half = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.head = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.nickname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.signature = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.trueName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
