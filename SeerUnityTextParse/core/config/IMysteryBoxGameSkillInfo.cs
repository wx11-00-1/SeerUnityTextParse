using System;

namespace core.config
{
	// Token: 0x0200271F RID: 10015
	public class IMysteryBoxGameSkillInfo : IConfigItem
	{
		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06013C23 RID: 80931 RVA: 0x0055CC44 File Offset: 0x0055AE44
		// (set) Token: 0x06013C24 RID: 80932 RVA: 0x0055CC4C File Offset: 0x0055AE4C
		public string des { get; set; }

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06013C25 RID: 80933 RVA: 0x0055CC55 File Offset: 0x0055AE55
		// (set) Token: 0x06013C26 RID: 80934 RVA: 0x0055CC5D File Offset: 0x0055AE5D
		public string skilltype { get; set; }

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x06013C27 RID: 80935 RVA: 0x0055CC66 File Offset: 0x0055AE66
		// (set) Token: 0x06013C28 RID: 80936 RVA: 0x0055CC6E File Offset: 0x0055AE6E
		public int id { get; set; }

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x06013C29 RID: 80937 RVA: 0x0055CC77 File Offset: 0x0055AE77
		// (set) Token: 0x06013C2A RID: 80938 RVA: 0x0055CC7F File Offset: 0x0055AE7F
		public int subtype { get; set; }

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x06013C2B RID: 80939 RVA: 0x0055CC88 File Offset: 0x0055AE88
		// (set) Token: 0x06013C2C RID: 80940 RVA: 0x0055CC90 File Offset: 0x0055AE90
		public int type { get; set; }

		// Token: 0x06013C2D RID: 80941 RVA: 0x0055CC9C File Offset: 0x0055AE9C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skilltype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
