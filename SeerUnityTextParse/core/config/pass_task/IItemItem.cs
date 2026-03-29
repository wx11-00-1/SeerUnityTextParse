using System;

namespace core.config.pass_task
{
	// Token: 0x02002504 RID: 9476
	public class IItemItem : IConfigItem
	{
		// Token: 0x17002418 RID: 9240
		// (get) Token: 0x06012590 RID: 75152 RVA: 0x004B73CC File Offset: 0x004B55CC
		// (set) Token: 0x06012591 RID: 75153 RVA: 0x004B73D4 File Offset: 0x004B55D4
		public string describe { get; set; }

		// Token: 0x17002419 RID: 9241
		// (get) Token: 0x06012592 RID: 75154 RVA: 0x004B73DD File Offset: 0x004B55DD
		// (set) Token: 0x06012593 RID: 75155 RVA: 0x004B73E5 File Offset: 0x004B55E5
		public string name { get; set; }

		// Token: 0x1700241A RID: 9242
		// (get) Token: 0x06012594 RID: 75156 RVA: 0x004B73EE File Offset: 0x004B55EE
		// (set) Token: 0x06012595 RID: 75157 RVA: 0x004B73F6 File Offset: 0x004B55F6
		public string reward { get; set; }

		// Token: 0x1700241B RID: 9243
		// (get) Token: 0x06012596 RID: 75158 RVA: 0x004B73FF File Offset: 0x004B55FF
		// (set) Token: 0x06012597 RID: 75159 RVA: 0x004B7407 File Offset: 0x004B5607
		public string taskparam { get; set; }

		// Token: 0x1700241C RID: 9244
		// (get) Token: 0x06012598 RID: 75160 RVA: 0x004B7410 File Offset: 0x004B5610
		// (set) Token: 0x06012599 RID: 75161 RVA: 0x004B7418 File Offset: 0x004B5618
		public string time2 { get; set; }

		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x0601259A RID: 75162 RVA: 0x004B7421 File Offset: 0x004B5621
		// (set) Token: 0x0601259B RID: 75163 RVA: 0x004B7429 File Offset: 0x004B5629
		public int id { get; set; }

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x0601259C RID: 75164 RVA: 0x004B7432 File Offset: 0x004B5632
		// (set) Token: 0x0601259D RID: 75165 RVA: 0x004B743A File Offset: 0x004B563A
		public int init { get; set; }

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x0601259E RID: 75166 RVA: 0x004B7443 File Offset: 0x004B5643
		// (set) Token: 0x0601259F RID: 75167 RVA: 0x004B744B File Offset: 0x004B564B
		public int num { get; set; }

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x060125A0 RID: 75168 RVA: 0x004B7454 File Offset: 0x004B5654
		// (set) Token: 0x060125A1 RID: 75169 RVA: 0x004B745C File Offset: 0x004B565C
		public int tasktype { get; set; }

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x060125A2 RID: 75170 RVA: 0x004B7465 File Offset: 0x004B5665
		// (set) Token: 0x060125A3 RID: 75171 RVA: 0x004B746D File Offset: 0x004B566D
		public int time { get; set; }

		// Token: 0x17002422 RID: 9250
		// (get) Token: 0x060125A4 RID: 75172 RVA: 0x004B7476 File Offset: 0x004B5676
		// (set) Token: 0x060125A5 RID: 75173 RVA: 0x004B747E File Offset: 0x004B567E
		public int type { get; set; }

		// Token: 0x17002423 RID: 9251
		// (get) Token: 0x060125A6 RID: 75174 RVA: 0x004B7487 File Offset: 0x004B5687
		// (set) Token: 0x060125A7 RID: 75175 RVA: 0x004B748F File Offset: 0x004B568F
		public int value { get; set; }

		// Token: 0x17002424 RID: 9252
		// (get) Token: 0x060125A8 RID: 75176 RVA: 0x004B7498 File Offset: 0x004B5698
		// (set) Token: 0x060125A9 RID: 75177 RVA: 0x004B74A0 File Offset: 0x004B56A0
		public int weight { get; set; }

		// Token: 0x060125AA RID: 75178 RVA: 0x004B74AC File Offset: 0x004B56AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.init = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskparam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.weight = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
