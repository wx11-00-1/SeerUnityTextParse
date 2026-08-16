using System;

namespace core.config
{
	// Token: 0x02002779 RID: 10105
	public class IArmorHeroXTGameLevelInfo : IConfigItem
	{
		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06013FF0 RID: 81904 RVA: 0x005A5224 File Offset: 0x005A3424
		// (set) Token: 0x06013FF1 RID: 81905 RVA: 0x005A522C File Offset: 0x005A342C
		public string monster { get; set; }

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06013FF2 RID: 81906 RVA: 0x005A5235 File Offset: 0x005A3435
		// (set) Token: 0x06013FF3 RID: 81907 RVA: 0x005A523D File Offset: 0x005A343D
		public int id { get; set; }

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06013FF4 RID: 81908 RVA: 0x005A5246 File Offset: 0x005A3446
		// (set) Token: 0x06013FF5 RID: 81909 RVA: 0x005A524E File Offset: 0x005A344E
		public int level { get; set; }

		// Token: 0x17001894 RID: 6292
		// (get) Token: 0x06013FF6 RID: 81910 RVA: 0x005A5257 File Offset: 0x005A3457
		// (set) Token: 0x06013FF7 RID: 81911 RVA: 0x005A525F File Offset: 0x005A345F
		public int num { get; set; }

		// Token: 0x06013FF8 RID: 81912 RVA: 0x005A5268 File Offset: 0x005A3468
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.level = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monster = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
