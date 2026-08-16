using System;

namespace core.config
{
	// Token: 0x02002777 RID: 10103
	public class IArmorHeroNWSkillInfo : IConfigItem
	{
		// Token: 0x17001889 RID: 6281
		// (get) Token: 0x06013FDC RID: 81884 RVA: 0x005A50B8 File Offset: 0x005A32B8
		// (set) Token: 0x06013FDD RID: 81885 RVA: 0x005A50C0 File Offset: 0x005A32C0
		public string des { get; set; }

		// Token: 0x1700188A RID: 6282
		// (get) Token: 0x06013FDE RID: 81886 RVA: 0x005A50C9 File Offset: 0x005A32C9
		// (set) Token: 0x06013FDF RID: 81887 RVA: 0x005A50D1 File Offset: 0x005A32D1
		public int end { get; set; }

		// Token: 0x1700188B RID: 6283
		// (get) Token: 0x06013FE0 RID: 81888 RVA: 0x005A50DA File Offset: 0x005A32DA
		// (set) Token: 0x06013FE1 RID: 81889 RVA: 0x005A50E2 File Offset: 0x005A32E2
		public int id { get; set; }

		// Token: 0x1700188C RID: 6284
		// (get) Token: 0x06013FE2 RID: 81890 RVA: 0x005A50EB File Offset: 0x005A32EB
		// (set) Token: 0x06013FE3 RID: 81891 RVA: 0x005A50F3 File Offset: 0x005A32F3
		public int level { get; set; }

		// Token: 0x1700188D RID: 6285
		// (get) Token: 0x06013FE4 RID: 81892 RVA: 0x005A50FC File Offset: 0x005A32FC
		// (set) Token: 0x06013FE5 RID: 81893 RVA: 0x005A5104 File Offset: 0x005A3304
		public int num { get; set; }

		// Token: 0x1700188E RID: 6286
		// (get) Token: 0x06013FE6 RID: 81894 RVA: 0x005A510D File Offset: 0x005A330D
		// (set) Token: 0x06013FE7 RID: 81895 RVA: 0x005A5115 File Offset: 0x005A3315
		public int start { get; set; }

		// Token: 0x1700188F RID: 6287
		// (get) Token: 0x06013FE8 RID: 81896 RVA: 0x005A511E File Offset: 0x005A331E
		// (set) Token: 0x06013FE9 RID: 81897 RVA: 0x005A5126 File Offset: 0x005A3326
		public int type { get; set; }

		// Token: 0x06013FEA RID: 81898 RVA: 0x005A5130 File Offset: 0x005A3330
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.end = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.start = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
