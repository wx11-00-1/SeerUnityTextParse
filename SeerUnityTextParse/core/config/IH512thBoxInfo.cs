using System;

namespace core.config
{
	// Token: 0x0200226B RID: 8811
	public class IH512thBoxInfo : IConfigItem
	{
		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06010A4C RID: 68172 RVA: 0x0048D768 File Offset: 0x0048B968
		// (set) Token: 0x06010A4D RID: 68173 RVA: 0x0048D770 File Offset: 0x0048B970
		public string rewardcnt { get; set; }

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06010A4E RID: 68174 RVA: 0x0048D779 File Offset: 0x0048B979
		// (set) Token: 0x06010A4F RID: 68175 RVA: 0x0048D781 File Offset: 0x0048B981
		public string rewardid { get; set; }

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06010A50 RID: 68176 RVA: 0x0048D78A File Offset: 0x0048B98A
		// (set) Token: 0x06010A51 RID: 68177 RVA: 0x0048D792 File Offset: 0x0048B992
		public string rewardpr { get; set; }

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06010A52 RID: 68178 RVA: 0x0048D79B File Offset: 0x0048B99B
		// (set) Token: 0x06010A53 RID: 68179 RVA: 0x0048D7A3 File Offset: 0x0048B9A3
		public string rewardtype { get; set; }

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06010A54 RID: 68180 RVA: 0x0048D7AC File Offset: 0x0048B9AC
		// (set) Token: 0x06010A55 RID: 68181 RVA: 0x0048D7B4 File Offset: 0x0048B9B4
		public int activitynum { get; set; }

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06010A56 RID: 68182 RVA: 0x0048D7BD File Offset: 0x0048B9BD
		// (set) Token: 0x06010A57 RID: 68183 RVA: 0x0048D7C5 File Offset: 0x0048B9C5
		public int exchangecut { get; set; }

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06010A58 RID: 68184 RVA: 0x0048D7CE File Offset: 0x0048B9CE
		// (set) Token: 0x06010A59 RID: 68185 RVA: 0x0048D7D6 File Offset: 0x0048B9D6
		public int id { get; set; }

		// Token: 0x06010A5A RID: 68186 RVA: 0x0048D7E0 File Offset: 0x0048B9E0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.activitynum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.exchangecut = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardpr = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
