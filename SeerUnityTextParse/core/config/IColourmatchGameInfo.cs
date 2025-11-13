using System;

namespace core.config
{
	// Token: 0x02001D0A RID: 7434
	public class IColourmatchGameInfo : IConfigItem
	{
		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x0600D8E6 RID: 55526 RVA: 0x003CFDC4 File Offset: 0x003CDFC4
		// (set) Token: 0x0600D8E7 RID: 55527 RVA: 0x003CFDCC File Offset: 0x003CDFCC
		public string endtips { get; set; }

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x0600D8E8 RID: 55528 RVA: 0x003CFDD5 File Offset: 0x003CDFD5
		// (set) Token: 0x0600D8E9 RID: 55529 RVA: 0x003CFDDD File Offset: 0x003CDFDD
		public string reward { get; set; }

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x0600D8EA RID: 55530 RVA: 0x003CFDE6 File Offset: 0x003CDFE6
		// (set) Token: 0x0600D8EB RID: 55531 RVA: 0x003CFDEE File Offset: 0x003CDFEE
		public string strattips { get; set; }

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x0600D8EC RID: 55532 RVA: 0x003CFDF7 File Offset: 0x003CDFF7
		// (set) Token: 0x0600D8ED RID: 55533 RVA: 0x003CFDFF File Offset: 0x003CDFFF
		public int[] endstatus { get; set; }

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x0600D8EE RID: 55534 RVA: 0x003CFE08 File Offset: 0x003CE008
		// (set) Token: 0x0600D8EF RID: 55535 RVA: 0x003CFE10 File Offset: 0x003CE010
		public int[] stratstatus { get; set; }

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x0600D8F0 RID: 55536 RVA: 0x003CFE19 File Offset: 0x003CE019
		// (set) Token: 0x0600D8F1 RID: 55537 RVA: 0x003CFE21 File Offset: 0x003CE021
		public int id { get; set; }

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x0600D8F2 RID: 55538 RVA: 0x003CFE2A File Offset: 0x003CE02A
		// (set) Token: 0x0600D8F3 RID: 55539 RVA: 0x003CFE32 File Offset: 0x003CE032
		public int opentime { get; set; }

		// Token: 0x0600D8F4 RID: 55540 RVA: 0x003CFE3C File Offset: 0x003CE03C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.endstatus = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.endstatus[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.endtips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.opentime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.stratstatus = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.stratstatus[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.strattips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
