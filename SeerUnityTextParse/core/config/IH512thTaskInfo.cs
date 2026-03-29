using System;

namespace core.config
{
	// Token: 0x0200226D RID: 8813
	public class IH512thTaskInfo : IConfigItem
	{
		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06010A60 RID: 68192 RVA: 0x0048D8E8 File Offset: 0x0048BAE8
		// (set) Token: 0x06010A61 RID: 68193 RVA: 0x0048D8F0 File Offset: 0x0048BAF0
		public string rewardcnt { get; set; }

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06010A62 RID: 68194 RVA: 0x0048D8F9 File Offset: 0x0048BAF9
		// (set) Token: 0x06010A63 RID: 68195 RVA: 0x0048D901 File Offset: 0x0048BB01
		public string rewardid { get; set; }

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x06010A64 RID: 68196 RVA: 0x0048D90A File Offset: 0x0048BB0A
		// (set) Token: 0x06010A65 RID: 68197 RVA: 0x0048D912 File Offset: 0x0048BB12
		public string rewardtype { get; set; }

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x06010A66 RID: 68198 RVA: 0x0048D91B File Offset: 0x0048BB1B
		// (set) Token: 0x06010A67 RID: 68199 RVA: 0x0048D923 File Offset: 0x0048BB23
		public string Taskdescription { get; set; }

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x06010A68 RID: 68200 RVA: 0x0048D92C File Offset: 0x0048BB2C
		// (set) Token: 0x06010A69 RID: 68201 RVA: 0x0048D934 File Offset: 0x0048BB34
		public string Tasktags { get; set; }

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x06010A6A RID: 68202 RVA: 0x0048D93D File Offset: 0x0048BB3D
		// (set) Token: 0x06010A6B RID: 68203 RVA: 0x0048D945 File Offset: 0x0048BB45
		public int id { get; set; }

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x06010A6C RID: 68204 RVA: 0x0048D94E File Offset: 0x0048BB4E
		// (set) Token: 0x06010A6D RID: 68205 RVA: 0x0048D956 File Offset: 0x0048BB56
		public int IsDailyTask { get; set; }

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x06010A6E RID: 68206 RVA: 0x0048D95F File Offset: 0x0048BB5F
		// (set) Token: 0x06010A6F RID: 68207 RVA: 0x0048D967 File Offset: 0x0048BB67
		public int Taskschedule { get; set; }

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06010A70 RID: 68208 RVA: 0x0048D970 File Offset: 0x0048BB70
		// (set) Token: 0x06010A71 RID: 68209 RVA: 0x0048D978 File Offset: 0x0048BB78
		public int Tasktype { get; set; }

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06010A72 RID: 68210 RVA: 0x0048D981 File Offset: 0x0048BB81
		// (set) Token: 0x06010A73 RID: 68211 RVA: 0x0048D989 File Offset: 0x0048BB89
		public int UserInfo { get; set; }

		// Token: 0x06010A74 RID: 68212 RVA: 0x0048D994 File Offset: 0x0048BB94
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.IsDailyTask = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Taskdescription = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Taskschedule = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Tasktags = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UserInfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
