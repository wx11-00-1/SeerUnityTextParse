using System;

namespace core.config
{
	// Token: 0x020026BD RID: 9917
	public class IStoryAnniversary2026FreeShopInfo : IConfigItem
	{
		// Token: 0x17002208 RID: 8712
		// (get) Token: 0x060134E2 RID: 79074 RVA: 0x00523510 File Offset: 0x00521710
		// (set) Token: 0x060134E3 RID: 79075 RVA: 0x00523518 File Offset: 0x00521718
		public string desc { get; set; }

		// Token: 0x17002209 RID: 8713
		// (get) Token: 0x060134E4 RID: 79076 RVA: 0x00523521 File Offset: 0x00521721
		// (set) Token: 0x060134E5 RID: 79077 RVA: 0x00523529 File Offset: 0x00521729
		public string price { get; set; }

		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x060134E6 RID: 79078 RVA: 0x00523532 File Offset: 0x00521732
		// (set) Token: 0x060134E7 RID: 79079 RVA: 0x0052353A File Offset: 0x0052173A
		public string reward { get; set; }

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x060134E8 RID: 79080 RVA: 0x00523543 File Offset: 0x00521743
		// (set) Token: 0x060134E9 RID: 79081 RVA: 0x0052354B File Offset: 0x0052174B
		public string stat { get; set; }

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x060134EA RID: 79082 RVA: 0x00523554 File Offset: 0x00521754
		// (set) Token: 0x060134EB RID: 79083 RVA: 0x0052355C File Offset: 0x0052175C
		public string taskInfo { get; set; }

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x060134EC RID: 79084 RVA: 0x00523565 File Offset: 0x00521765
		// (set) Token: 0x060134ED RID: 79085 RVA: 0x0052356D File Offset: 0x0052176D
		public int endtime { get; set; }

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x060134EE RID: 79086 RVA: 0x00523576 File Offset: 0x00521776
		// (set) Token: 0x060134EF RID: 79087 RVA: 0x0052357E File Offset: 0x0052177E
		public int id { get; set; }

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x060134F0 RID: 79088 RVA: 0x00523587 File Offset: 0x00521787
		// (set) Token: 0x060134F1 RID: 79089 RVA: 0x0052358F File Offset: 0x0052178F
		public int tasktype { get; set; }

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x060134F2 RID: 79090 RVA: 0x00523598 File Offset: 0x00521798
		// (set) Token: 0x060134F3 RID: 79091 RVA: 0x005235A0 File Offset: 0x005217A0
		public int taskValue { get; set; }

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x060134F4 RID: 79092 RVA: 0x005235A9 File Offset: 0x005217A9
		// (set) Token: 0x060134F5 RID: 79093 RVA: 0x005235B1 File Offset: 0x005217B1
		public int type { get; set; }

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x060134F6 RID: 79094 RVA: 0x005235BA File Offset: 0x005217BA
		// (set) Token: 0x060134F7 RID: 79095 RVA: 0x005235C2 File Offset: 0x005217C2
		public int userbitbuf { get; set; }

		// Token: 0x17002213 RID: 8723
		// (get) Token: 0x060134F8 RID: 79096 RVA: 0x005235CB File Offset: 0x005217CB
		// (set) Token: 0x060134F9 RID: 79097 RVA: 0x005235D3 File Offset: 0x005217D3
		public int userinfo { get; set; }

		// Token: 0x17002214 RID: 8724
		// (get) Token: 0x060134FA RID: 79098 RVA: 0x005235DC File Offset: 0x005217DC
		// (set) Token: 0x060134FB RID: 79099 RVA: 0x005235E4 File Offset: 0x005217E4
		public int value { get; set; }

		// Token: 0x060134FC RID: 79100 RVA: 0x005235F0 File Offset: 0x005217F0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stat = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskInfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskValue = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userbitbuf = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
