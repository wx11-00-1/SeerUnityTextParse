using System;

namespace core.config
{
	// Token: 0x0200221B RID: 8731
	public class IDiamonTaskInfo : IConfigItem
	{
		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x060106BA RID: 67258 RVA: 0x004890C8 File Offset: 0x004872C8
		// (set) Token: 0x060106BB RID: 67259 RVA: 0x004890D0 File Offset: 0x004872D0
		public string H5go { get; set; }

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x060106BC RID: 67260 RVA: 0x004890D9 File Offset: 0x004872D9
		// (set) Token: 0x060106BD RID: 67261 RVA: 0x004890E1 File Offset: 0x004872E1
		public string Rewardcnt { get; set; }

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x060106BE RID: 67262 RVA: 0x004890EA File Offset: 0x004872EA
		// (set) Token: 0x060106BF RID: 67263 RVA: 0x004890F2 File Offset: 0x004872F2
		public string Rewardid { get; set; }

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x060106C0 RID: 67264 RVA: 0x004890FB File Offset: 0x004872FB
		// (set) Token: 0x060106C1 RID: 67265 RVA: 0x00489103 File Offset: 0x00487303
		public string Rewardtype { get; set; }

		// Token: 0x17001906 RID: 6406
		// (get) Token: 0x060106C2 RID: 67266 RVA: 0x0048910C File Offset: 0x0048730C
		// (set) Token: 0x060106C3 RID: 67267 RVA: 0x00489114 File Offset: 0x00487314
		public string Taskdescription { get; set; }

		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x060106C4 RID: 67268 RVA: 0x0048911D File Offset: 0x0048731D
		// (set) Token: 0x060106C5 RID: 67269 RVA: 0x00489125 File Offset: 0x00487325
		public string Tasktags { get; set; }

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060106C6 RID: 67270 RVA: 0x0048912E File Offset: 0x0048732E
		// (set) Token: 0x060106C7 RID: 67271 RVA: 0x00489136 File Offset: 0x00487336
		public int id { get; set; }

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060106C8 RID: 67272 RVA: 0x0048913F File Offset: 0x0048733F
		// (set) Token: 0x060106C9 RID: 67273 RVA: 0x00489147 File Offset: 0x00487347
		public int Taskschedule { get; set; }

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060106CA RID: 67274 RVA: 0x00489150 File Offset: 0x00487350
		// (set) Token: 0x060106CB RID: 67275 RVA: 0x00489158 File Offset: 0x00487358
		public int Tasktype { get; set; }

		// Token: 0x060106CC RID: 67276 RVA: 0x00489164 File Offset: 0x00487364
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.H5go = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Rewardtype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Taskdescription = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Taskschedule = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Tasktags = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
