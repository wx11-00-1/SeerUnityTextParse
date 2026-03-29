using System;

namespace core.config
{
	// Token: 0x0200218B RID: 8587
	public class IBravecommtaskInfo : IConfigItem
	{
		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x0601004E RID: 65614 RVA: 0x00481670 File Offset: 0x0047F870
		// (set) Token: 0x0601004F RID: 65615 RVA: 0x00481678 File Offset: 0x0047F878
		public string jump { get; set; }

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06010050 RID: 65616 RVA: 0x00481681 File Offset: 0x0047F881
		// (set) Token: 0x06010051 RID: 65617 RVA: 0x00481689 File Offset: 0x0047F889
		public string NewMsglogId { get; set; }

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x06010052 RID: 65618 RVA: 0x00481692 File Offset: 0x0047F892
		// (set) Token: 0x06010053 RID: 65619 RVA: 0x0048169A File Offset: 0x0047F89A
		public string rewardinfo { get; set; }

		// Token: 0x1700165F RID: 5727
		// (get) Token: 0x06010054 RID: 65620 RVA: 0x004816A3 File Offset: 0x0047F8A3
		// (set) Token: 0x06010055 RID: 65621 RVA: 0x004816AB File Offset: 0x0047F8AB
		public string taskparam { get; set; }

		// Token: 0x17001660 RID: 5728
		// (get) Token: 0x06010056 RID: 65622 RVA: 0x004816B4 File Offset: 0x0047F8B4
		// (set) Token: 0x06010057 RID: 65623 RVA: 0x004816BC File Offset: 0x0047F8BC
		public string title { get; set; }

		// Token: 0x17001661 RID: 5729
		// (get) Token: 0x06010058 RID: 65624 RVA: 0x004816C5 File Offset: 0x0047F8C5
		// (set) Token: 0x06010059 RID: 65625 RVA: 0x004816CD File Offset: 0x0047F8CD
		public string value { get; set; }

		// Token: 0x17001662 RID: 5730
		// (get) Token: 0x0601005A RID: 65626 RVA: 0x004816D6 File Offset: 0x0047F8D6
		// (set) Token: 0x0601005B RID: 65627 RVA: 0x004816DE File Offset: 0x0047F8DE
		public int group { get; set; }

		// Token: 0x17001663 RID: 5731
		// (get) Token: 0x0601005C RID: 65628 RVA: 0x004816E7 File Offset: 0x0047F8E7
		// (set) Token: 0x0601005D RID: 65629 RVA: 0x004816EF File Offset: 0x0047F8EF
		public int id { get; set; }

		// Token: 0x17001664 RID: 5732
		// (get) Token: 0x0601005E RID: 65630 RVA: 0x004816F8 File Offset: 0x0047F8F8
		// (set) Token: 0x0601005F RID: 65631 RVA: 0x00481700 File Offset: 0x0047F900
		public int init { get; set; }

		// Token: 0x17001665 RID: 5733
		// (get) Token: 0x06010060 RID: 65632 RVA: 0x00481709 File Offset: 0x0047F909
		// (set) Token: 0x06010061 RID: 65633 RVA: 0x00481711 File Offset: 0x0047F911
		public int num { get; set; }

		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06010062 RID: 65634 RVA: 0x0048171A File Offset: 0x0047F91A
		// (set) Token: 0x06010063 RID: 65635 RVA: 0x00481722 File Offset: 0x0047F922
		public int tasktype { get; set; }

		// Token: 0x06010064 RID: 65636 RVA: 0x0048172C File Offset: 0x0047F92C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewMsglogId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.group = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.init = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jump = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskparam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
