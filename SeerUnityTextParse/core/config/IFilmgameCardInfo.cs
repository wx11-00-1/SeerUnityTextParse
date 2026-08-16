using System;

namespace core.config
{
	// Token: 0x020028C5 RID: 10437
	public class IFilmgameCardInfo : IConfigItem
	{
		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x06014E72 RID: 85618 RVA: 0x005B6590 File Offset: 0x005B4790
		// (set) Token: 0x06014E73 RID: 85619 RVA: 0x005B6598 File Offset: 0x005B4798
		public string cardname { get; set; }

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x06014E74 RID: 85620 RVA: 0x005B65A1 File Offset: 0x005B47A1
		// (set) Token: 0x06014E75 RID: 85621 RVA: 0x005B65A9 File Offset: 0x005B47A9
		public string image { get; set; }

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x06014E76 RID: 85622 RVA: 0x005B65B2 File Offset: 0x005B47B2
		// (set) Token: 0x06014E77 RID: 85623 RVA: 0x005B65BA File Offset: 0x005B47BA
		public int id { get; set; }

		// Token: 0x06014E78 RID: 85624 RVA: 0x005B65C3 File Offset: 0x005B47C3
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.cardname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
