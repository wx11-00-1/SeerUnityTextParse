using System;

namespace core.config
{
	// Token: 0x02002037 RID: 8247
	public class IMountTailInfo : IConfigItem
	{
		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x0600F824 RID: 63524 RVA: 0x0043C86C File Offset: 0x0043AA6C
		// (set) Token: 0x0600F825 RID: 63525 RVA: 0x0043C874 File Offset: 0x0043AA74
		public string coord { get; set; }

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x0600F826 RID: 63526 RVA: 0x0043C87D File Offset: 0x0043AA7D
		// (set) Token: 0x0600F827 RID: 63527 RVA: 0x0043C885 File Offset: 0x0043AA85
		public string name { get; set; }

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600F828 RID: 63528 RVA: 0x0043C88E File Offset: 0x0043AA8E
		// (set) Token: 0x0600F829 RID: 63529 RVA: 0x0043C896 File Offset: 0x0043AA96
		public int id { get; set; }

		// Token: 0x0600F82A RID: 63530 RVA: 0x0043C89F File Offset: 0x0043AA9F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.coord = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
