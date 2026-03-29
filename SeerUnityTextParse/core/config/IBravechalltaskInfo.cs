using System;

namespace core.config
{
	// Token: 0x02002189 RID: 8585
	public class IBravechalltaskInfo : IConfigItem
	{
		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06010032 RID: 65586 RVA: 0x00481468 File Offset: 0x0047F668
		// (set) Token: 0x06010033 RID: 65587 RVA: 0x00481470 File Offset: 0x0047F670
		public string jump { get; set; }

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x06010034 RID: 65588 RVA: 0x00481479 File Offset: 0x0047F679
		// (set) Token: 0x06010035 RID: 65589 RVA: 0x00481481 File Offset: 0x0047F681
		public string NewMsglogId { get; set; }

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x06010036 RID: 65590 RVA: 0x0048148A File Offset: 0x0047F68A
		// (set) Token: 0x06010037 RID: 65591 RVA: 0x00481492 File Offset: 0x0047F692
		public string rewardinfo { get; set; }

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06010038 RID: 65592 RVA: 0x0048149B File Offset: 0x0047F69B
		// (set) Token: 0x06010039 RID: 65593 RVA: 0x004814A3 File Offset: 0x0047F6A3
		public string taskparam { get; set; }

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x0601003A RID: 65594 RVA: 0x004814AC File Offset: 0x0047F6AC
		// (set) Token: 0x0601003B RID: 65595 RVA: 0x004814B4 File Offset: 0x0047F6B4
		public string title { get; set; }

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x0601003C RID: 65596 RVA: 0x004814BD File Offset: 0x0047F6BD
		// (set) Token: 0x0601003D RID: 65597 RVA: 0x004814C5 File Offset: 0x0047F6C5
		public string value { get; set; }

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x0601003E RID: 65598 RVA: 0x004814CE File Offset: 0x0047F6CE
		// (set) Token: 0x0601003F RID: 65599 RVA: 0x004814D6 File Offset: 0x0047F6D6
		public int group { get; set; }

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06010040 RID: 65600 RVA: 0x004814DF File Offset: 0x0047F6DF
		// (set) Token: 0x06010041 RID: 65601 RVA: 0x004814E7 File Offset: 0x0047F6E7
		public int id { get; set; }

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06010042 RID: 65602 RVA: 0x004814F0 File Offset: 0x0047F6F0
		// (set) Token: 0x06010043 RID: 65603 RVA: 0x004814F8 File Offset: 0x0047F6F8
		public int init { get; set; }

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06010044 RID: 65604 RVA: 0x00481501 File Offset: 0x0047F701
		// (set) Token: 0x06010045 RID: 65605 RVA: 0x00481509 File Offset: 0x0047F709
		public int num { get; set; }

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06010046 RID: 65606 RVA: 0x00481512 File Offset: 0x0047F712
		// (set) Token: 0x06010047 RID: 65607 RVA: 0x0048151A File Offset: 0x0047F71A
		public int tasktype { get; set; }

		// Token: 0x06010048 RID: 65608 RVA: 0x00481524 File Offset: 0x0047F724
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
