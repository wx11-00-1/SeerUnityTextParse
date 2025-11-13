using System;

namespace core.config
{
	// Token: 0x02001D48 RID: 7496
	public class IExpressJumpInfo : IConfigItem
	{
		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x0600DB40 RID: 56128 RVA: 0x003D2AA4 File Offset: 0x003D0CA4
		// (set) Token: 0x0600DB41 RID: 56129 RVA: 0x003D2AAC File Offset: 0x003D0CAC
		public string dest { get; set; }

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x0600DB42 RID: 56130 RVA: 0x003D2AB5 File Offset: 0x003D0CB5
		// (set) Token: 0x0600DB43 RID: 56131 RVA: 0x003D2ABD File Offset: 0x003D0CBD
		public string image { get; set; }

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x0600DB44 RID: 56132 RVA: 0x003D2AC6 File Offset: 0x003D0CC6
		// (set) Token: 0x0600DB45 RID: 56133 RVA: 0x003D2ACE File Offset: 0x003D0CCE
		public string name { get; set; }

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x0600DB46 RID: 56134 RVA: 0x003D2AD7 File Offset: 0x003D0CD7
		// (set) Token: 0x0600DB47 RID: 56135 RVA: 0x003D2ADF File Offset: 0x003D0CDF
		public int clickLock { get; set; }

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x0600DB48 RID: 56136 RVA: 0x003D2AE8 File Offset: 0x003D0CE8
		// (set) Token: 0x0600DB49 RID: 56137 RVA: 0x003D2AF0 File Offset: 0x003D0CF0
		public int closeother { get; set; }

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x0600DB4A RID: 56138 RVA: 0x003D2AF9 File Offset: 0x003D0CF9
		// (set) Token: 0x0600DB4B RID: 56139 RVA: 0x003D2B01 File Offset: 0x003D0D01
		public int id { get; set; }

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x0600DB4C RID: 56140 RVA: 0x003D2B0A File Offset: 0x003D0D0A
		// (set) Token: 0x0600DB4D RID: 56141 RVA: 0x003D2B12 File Offset: 0x003D0D12
		public int priority { get; set; }

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x0600DB4E RID: 56142 RVA: 0x003D2B1B File Offset: 0x003D0D1B
		// (set) Token: 0x0600DB4F RID: 56143 RVA: 0x003D2B23 File Offset: 0x003D0D23
		public int reddotid { get; set; }

		// Token: 0x0600DB50 RID: 56144 RVA: 0x003D2B2C File Offset: 0x003D0D2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.clickLock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.closeother = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.dest = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.priority = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reddotid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
