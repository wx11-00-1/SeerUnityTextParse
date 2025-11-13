using System;

namespace core.config
{
	// Token: 0x02001DEA RID: 7658
	public class IPvpTaskInfo : IConfigItem
	{
		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x0600E1E0 RID: 57824 RVA: 0x003DB08C File Offset: 0x003D928C
		// (set) Token: 0x0600E1E1 RID: 57825 RVA: 0x003DB094 File Offset: 0x003D9294
		public string describe { get; set; }

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x0600E1E2 RID: 57826 RVA: 0x003DB09D File Offset: 0x003D929D
		// (set) Token: 0x0600E1E3 RID: 57827 RVA: 0x003DB0A5 File Offset: 0x003D92A5
		public string rewardinfo { get; set; }

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x0600E1E4 RID: 57828 RVA: 0x003DB0AE File Offset: 0x003D92AE
		// (set) Token: 0x0600E1E5 RID: 57829 RVA: 0x003DB0B6 File Offset: 0x003D92B6
		public string title { get; set; }

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x0600E1E6 RID: 57830 RVA: 0x003DB0BF File Offset: 0x003D92BF
		// (set) Token: 0x0600E1E7 RID: 57831 RVA: 0x003DB0C7 File Offset: 0x003D92C7
		public int exp { get; set; }

		// Token: 0x1700179C RID: 6044
		// (get) Token: 0x0600E1E8 RID: 57832 RVA: 0x003DB0D0 File Offset: 0x003D92D0
		// (set) Token: 0x0600E1E9 RID: 57833 RVA: 0x003DB0D8 File Offset: 0x003D92D8
		public int id { get; set; }

		// Token: 0x1700179D RID: 6045
		// (get) Token: 0x0600E1EA RID: 57834 RVA: 0x003DB0E1 File Offset: 0x003D92E1
		// (set) Token: 0x0600E1EB RID: 57835 RVA: 0x003DB0E9 File Offset: 0x003D92E9
		public int pos { get; set; }

		// Token: 0x1700179E RID: 6046
		// (get) Token: 0x0600E1EC RID: 57836 RVA: 0x003DB0F2 File Offset: 0x003D92F2
		// (set) Token: 0x0600E1ED RID: 57837 RVA: 0x003DB0FA File Offset: 0x003D92FA
		public int rarity { get; set; }

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x0600E1EE RID: 57838 RVA: 0x003DB103 File Offset: 0x003D9303
		// (set) Token: 0x0600E1EF RID: 57839 RVA: 0x003DB10B File Offset: 0x003D930B
		public int subkey { get; set; }

		// Token: 0x170017A0 RID: 6048
		// (get) Token: 0x0600E1F0 RID: 57840 RVA: 0x003DB114 File Offset: 0x003D9314
		// (set) Token: 0x0600E1F1 RID: 57841 RVA: 0x003DB11C File Offset: 0x003D931C
		public int time { get; set; }

		// Token: 0x170017A1 RID: 6049
		// (get) Token: 0x0600E1F2 RID: 57842 RVA: 0x003DB125 File Offset: 0x003D9325
		// (set) Token: 0x0600E1F3 RID: 57843 RVA: 0x003DB12D File Offset: 0x003D932D
		public int userinfo { get; set; }

		// Token: 0x170017A2 RID: 6050
		// (get) Token: 0x0600E1F4 RID: 57844 RVA: 0x003DB136 File Offset: 0x003D9336
		// (set) Token: 0x0600E1F5 RID: 57845 RVA: 0x003DB13E File Offset: 0x003D933E
		public int value { get; set; }

		// Token: 0x0600E1F6 RID: 57846 RVA: 0x003DB148 File Offset: 0x003D9348
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pos = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.subkey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
