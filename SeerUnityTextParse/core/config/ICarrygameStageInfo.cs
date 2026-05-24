using System;

namespace core.config
{
	// Token: 0x020024BF RID: 9407
	public class ICarrygameStageInfo : IConfigItem
	{
		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06011E40 RID: 73280 RVA: 0x00507B60 File Offset: 0x00505D60
		// (set) Token: 0x06011E41 RID: 73281 RVA: 0x00507B68 File Offset: 0x00505D68
		public int id { get; set; }

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06011E42 RID: 73282 RVA: 0x00507B71 File Offset: 0x00505D71
		// (set) Token: 0x06011E43 RID: 73283 RVA: 0x00507B79 File Offset: 0x00505D79
		public int num1 { get; set; }

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06011E44 RID: 73284 RVA: 0x00507B82 File Offset: 0x00505D82
		// (set) Token: 0x06011E45 RID: 73285 RVA: 0x00507B8A File Offset: 0x00505D8A
		public int num2 { get; set; }

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06011E46 RID: 73286 RVA: 0x00507B93 File Offset: 0x00505D93
		// (set) Token: 0x06011E47 RID: 73287 RVA: 0x00507B9B File Offset: 0x00505D9B
		public int num3 { get; set; }

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06011E48 RID: 73288 RVA: 0x00507BA4 File Offset: 0x00505DA4
		// (set) Token: 0x06011E49 RID: 73289 RVA: 0x00507BAC File Offset: 0x00505DAC
		public int time { get; set; }

		// Token: 0x06011E4A RID: 73290 RVA: 0x00507BB8 File Offset: 0x00505DB8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.num1 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
