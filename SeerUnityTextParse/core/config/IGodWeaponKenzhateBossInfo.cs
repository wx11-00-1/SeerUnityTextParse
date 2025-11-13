using System;

namespace core.config
{
	// Token: 0x02001D60 RID: 7520
	public class IGodWeaponKenzhateBossInfo : IConfigItem
	{
		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x0600DC32 RID: 56370 RVA: 0x003D3F94 File Offset: 0x003D2194
		// (set) Token: 0x0600DC33 RID: 56371 RVA: 0x003D3F9C File Offset: 0x003D219C
		public string parm1 { get; set; }

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x0600DC34 RID: 56372 RVA: 0x003D3FA5 File Offset: 0x003D21A5
		// (set) Token: 0x0600DC35 RID: 56373 RVA: 0x003D3FAD File Offset: 0x003D21AD
		public string parm2 { get; set; }

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x0600DC36 RID: 56374 RVA: 0x003D3FB6 File Offset: 0x003D21B6
		// (set) Token: 0x0600DC37 RID: 56375 RVA: 0x003D3FBE File Offset: 0x003D21BE
		public int id { get; set; }

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x0600DC38 RID: 56376 RVA: 0x003D3FC7 File Offset: 0x003D21C7
		// (set) Token: 0x0600DC39 RID: 56377 RVA: 0x003D3FCF File Offset: 0x003D21CF
		public int petid { get; set; }

		// Token: 0x0600DC3A RID: 56378 RVA: 0x003D3FD8 File Offset: 0x003D21D8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.parm1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.parm2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
