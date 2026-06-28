using System;

namespace core.config
{
	// Token: 0x0200255B RID: 9563
	public class IAutocardbattlepassRewardInfo : IConfigItem
	{
		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x0601286F RID: 75887 RVA: 0x00545264 File Offset: 0x00543464
		// (set) Token: 0x06012870 RID: 75888 RVA: 0x0054526C File Offset: 0x0054346C
		public string freereward { get; set; }

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06012871 RID: 75889 RVA: 0x00545275 File Offset: 0x00543475
		// (set) Token: 0x06012872 RID: 75890 RVA: 0x0054527D File Offset: 0x0054347D
		public int exp { get; set; }

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06012873 RID: 75891 RVA: 0x00545286 File Offset: 0x00543486
		// (set) Token: 0x06012874 RID: 75892 RVA: 0x0054528E File Offset: 0x0054348E
		public int id { get; set; }

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06012875 RID: 75893 RVA: 0x00545297 File Offset: 0x00543497
		// (set) Token: 0x06012876 RID: 75894 RVA: 0x0054529F File Offset: 0x0054349F
		public int mainreward { get; set; }

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06012877 RID: 75895 RVA: 0x005452A8 File Offset: 0x005434A8
		// (set) Token: 0x06012878 RID: 75896 RVA: 0x005452B0 File Offset: 0x005434B0
		public int paytype { get; set; }

		// Token: 0x06012879 RID: 75897 RVA: 0x005452BC File Offset: 0x005434BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.freereward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.mainreward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.paytype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
