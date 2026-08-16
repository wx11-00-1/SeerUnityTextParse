using System;

namespace core.config
{
	// Token: 0x02002775 RID: 10101
	public class IArmorHeroNWMonsterInfo : IConfigItem
	{
		// Token: 0x17001884 RID: 6276
		// (get) Token: 0x06013FCE RID: 81870 RVA: 0x005A4FB4 File Offset: 0x005A31B4
		// (set) Token: 0x06013FCF RID: 81871 RVA: 0x005A4FBC File Offset: 0x005A31BC
		public string act { get; set; }

		// Token: 0x17001885 RID: 6277
		// (get) Token: 0x06013FD0 RID: 81872 RVA: 0x005A4FC5 File Offset: 0x005A31C5
		// (set) Token: 0x06013FD1 RID: 81873 RVA: 0x005A4FCD File Offset: 0x005A31CD
		public int gameid { get; set; }

		// Token: 0x17001886 RID: 6278
		// (get) Token: 0x06013FD2 RID: 81874 RVA: 0x005A4FD6 File Offset: 0x005A31D6
		// (set) Token: 0x06013FD3 RID: 81875 RVA: 0x005A4FDE File Offset: 0x005A31DE
		public int hp { get; set; }

		// Token: 0x17001887 RID: 6279
		// (get) Token: 0x06013FD4 RID: 81876 RVA: 0x005A4FE7 File Offset: 0x005A31E7
		// (set) Token: 0x06013FD5 RID: 81877 RVA: 0x005A4FEF File Offset: 0x005A31EF
		public int id { get; set; }

		// Token: 0x06013FD6 RID: 81878 RVA: 0x005A4FF8 File Offset: 0x005A31F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.act = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.gameid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
