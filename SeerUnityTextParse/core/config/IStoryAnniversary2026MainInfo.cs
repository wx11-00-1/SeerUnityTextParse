using System;

namespace core.config
{
	// Token: 0x020026C1 RID: 9921
	public class IStoryAnniversary2026MainInfo : IConfigItem
	{
		// Token: 0x1700221D RID: 8733
		// (get) Token: 0x06013514 RID: 79124 RVA: 0x005238A8 File Offset: 0x00521AA8
		// (set) Token: 0x06013515 RID: 79125 RVA: 0x005238B0 File Offset: 0x00521AB0
		public string field { get; set; }

		// Token: 0x1700221E RID: 8734
		// (get) Token: 0x06013516 RID: 79126 RVA: 0x005238B9 File Offset: 0x00521AB9
		// (set) Token: 0x06013517 RID: 79127 RVA: 0x005238C1 File Offset: 0x00521AC1
		public string name { get; set; }

		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x06013518 RID: 79128 RVA: 0x005238CA File Offset: 0x00521ACA
		// (set) Token: 0x06013519 RID: 79129 RVA: 0x005238D2 File Offset: 0x00521AD2
		public int id { get; set; }

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x0601351A RID: 79130 RVA: 0x005238DB File Offset: 0x00521ADB
		// (set) Token: 0x0601351B RID: 79131 RVA: 0x005238E3 File Offset: 0x00521AE3
		public int linkID { get; set; }

		// Token: 0x17002221 RID: 8737
		// (get) Token: 0x0601351C RID: 79132 RVA: 0x005238EC File Offset: 0x00521AEC
		// (set) Token: 0x0601351D RID: 79133 RVA: 0x005238F4 File Offset: 0x00521AF4
		public int title { get; set; }

		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x0601351E RID: 79134 RVA: 0x005238FD File Offset: 0x00521AFD
		// (set) Token: 0x0601351F RID: 79135 RVA: 0x00523905 File Offset: 0x00521B05
		public int type { get; set; }

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x06013520 RID: 79136 RVA: 0x0052390E File Offset: 0x00521B0E
		// (set) Token: 0x06013521 RID: 79137 RVA: 0x00523916 File Offset: 0x00521B16
		public int unlock { get; set; }

		// Token: 0x06013522 RID: 79138 RVA: 0x00523920 File Offset: 0x00521B20
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.field = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.linkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
