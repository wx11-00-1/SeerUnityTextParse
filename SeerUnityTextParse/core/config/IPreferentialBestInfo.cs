using System;

namespace core.config
{
	// Token: 0x020022F5 RID: 8949
	public class IPreferentialBestInfo : IConfigItem
	{
		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x0601101E RID: 69662 RVA: 0x00494A1C File Offset: 0x00492C1C
		// (set) Token: 0x0601101F RID: 69663 RVA: 0x00494A24 File Offset: 0x00492C24
		public string canchoose { get; set; }

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06011020 RID: 69664 RVA: 0x00494A2D File Offset: 0x00492C2D
		// (set) Token: 0x06011021 RID: 69665 RVA: 0x00494A35 File Offset: 0x00492C35
		public string price { get; set; }

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06011022 RID: 69666 RVA: 0x00494A3E File Offset: 0x00492C3E
		// (set) Token: 0x06011023 RID: 69667 RVA: 0x00494A46 File Offset: 0x00492C46
		public string recommendlearningability { get; set; }

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x06011024 RID: 69668 RVA: 0x00494A4F File Offset: 0x00492C4F
		// (set) Token: 0x06011025 RID: 69669 RVA: 0x00494A57 File Offset: 0x00492C57
		public string skinname { get; set; }

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06011026 RID: 69670 RVA: 0x00494A60 File Offset: 0x00492C60
		// (set) Token: 0x06011027 RID: 69671 RVA: 0x00494A68 File Offset: 0x00492C68
		public int id { get; set; }

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06011028 RID: 69672 RVA: 0x00494A71 File Offset: 0x00492C71
		// (set) Token: 0x06011029 RID: 69673 RVA: 0x00494A79 File Offset: 0x00492C79
		public int iscommon { get; set; }

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x0601102A RID: 69674 RVA: 0x00494A82 File Offset: 0x00492C82
		// (set) Token: 0x0601102B RID: 69675 RVA: 0x00494A8A File Offset: 0x00492C8A
		public int petid { get; set; }

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x0601102C RID: 69676 RVA: 0x00494A93 File Offset: 0x00492C93
		// (set) Token: 0x0601102D RID: 69677 RVA: 0x00494A9B File Offset: 0x00492C9B
		public int recommendnature { get; set; }

		// Token: 0x0601102E RID: 69678 RVA: 0x00494AA4 File Offset: 0x00492CA4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.canchoose = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.iscommon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.recommendlearningability = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.recommendnature = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skinname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
