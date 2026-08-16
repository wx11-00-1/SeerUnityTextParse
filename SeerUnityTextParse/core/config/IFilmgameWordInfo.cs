using System;

namespace core.config
{
	// Token: 0x020028CD RID: 10445
	public class IFilmgameWordInfo : IConfigItem
	{
		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06014EB4 RID: 85684 RVA: 0x005B6A88 File Offset: 0x005B4C88
		// (set) Token: 0x06014EB5 RID: 85685 RVA: 0x005B6A90 File Offset: 0x005B4C90
		public string word { get; set; }

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x06014EB6 RID: 85686 RVA: 0x005B6A99 File Offset: 0x005B4C99
		// (set) Token: 0x06014EB7 RID: 85687 RVA: 0x005B6AA1 File Offset: 0x005B4CA1
		public int id { get; set; }

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x06014EB8 RID: 85688 RVA: 0x005B6AAA File Offset: 0x005B4CAA
		// (set) Token: 0x06014EB9 RID: 85689 RVA: 0x005B6AB2 File Offset: 0x005B4CB2
		public int wordtype { get; set; }

		// Token: 0x06014EBA RID: 85690 RVA: 0x005B6ABB File Offset: 0x005B4CBB
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.word = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.wordtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
