using System;

namespace core.config
{
	// Token: 0x0200271B RID: 10011
	public class IMysteryBoxGameItemInfo : IConfigItem
	{
		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x06013BEF RID: 80879 RVA: 0x0055C87C File Offset: 0x0055AA7C
		// (set) Token: 0x06013BF0 RID: 80880 RVA: 0x0055C884 File Offset: 0x0055AA84
		public string des { get; set; }

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x06013BF1 RID: 80881 RVA: 0x0055C88D File Offset: 0x0055AA8D
		// (set) Token: 0x06013BF2 RID: 80882 RVA: 0x0055C895 File Offset: 0x0055AA95
		public string name { get; set; }

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x06013BF3 RID: 80883 RVA: 0x0055C89E File Offset: 0x0055AA9E
		// (set) Token: 0x06013BF4 RID: 80884 RVA: 0x0055C8A6 File Offset: 0x0055AAA6
		public int id { get; set; }

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06013BF5 RID: 80885 RVA: 0x0055C8AF File Offset: 0x0055AAAF
		// (set) Token: 0x06013BF6 RID: 80886 RVA: 0x0055C8B7 File Offset: 0x0055AAB7
		public int price { get; set; }

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06013BF7 RID: 80887 RVA: 0x0055C8C0 File Offset: 0x0055AAC0
		// (set) Token: 0x06013BF8 RID: 80888 RVA: 0x0055C8C8 File Offset: 0x0055AAC8
		public int rare { get; set; }

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x06013BF9 RID: 80889 RVA: 0x0055C8D1 File Offset: 0x0055AAD1
		// (set) Token: 0x06013BFA RID: 80890 RVA: 0x0055C8D9 File Offset: 0x0055AAD9
		public int size { get; set; }

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x06013BFB RID: 80891 RVA: 0x0055C8E2 File Offset: 0x0055AAE2
		// (set) Token: 0x06013BFC RID: 80892 RVA: 0x0055C8EA File Offset: 0x0055AAEA
		public int type { get; set; }

		// Token: 0x06013BFD RID: 80893 RVA: 0x0055C8F4 File Offset: 0x0055AAF4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rare = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.size = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
