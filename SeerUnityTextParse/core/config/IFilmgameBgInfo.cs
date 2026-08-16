using System;

namespace core.config
{
	// Token: 0x020028C3 RID: 10435
	public class IFilmgameBgInfo : IConfigItem
	{
		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x06014E66 RID: 85606 RVA: 0x005B64A0 File Offset: 0x005B46A0
		// (set) Token: 0x06014E67 RID: 85607 RVA: 0x005B64A8 File Offset: 0x005B46A8
		public string bgimage { get; set; }

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x06014E68 RID: 85608 RVA: 0x005B64B1 File Offset: 0x005B46B1
		// (set) Token: 0x06014E69 RID: 85609 RVA: 0x005B64B9 File Offset: 0x005B46B9
		public string bgname { get; set; }

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x06014E6A RID: 85610 RVA: 0x005B64C2 File Offset: 0x005B46C2
		// (set) Token: 0x06014E6B RID: 85611 RVA: 0x005B64CA File Offset: 0x005B46CA
		public int id { get; set; }

		// Token: 0x06014E6C RID: 85612 RVA: 0x005B64D3 File Offset: 0x005B46D3
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bgimage = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bgname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
