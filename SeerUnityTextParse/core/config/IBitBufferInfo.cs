using System;

namespace core.config
{
	// Token: 0x02001CC8 RID: 7368
	public class IBitBufferInfo : IConfigItem
	{
		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x0600D5DE RID: 54750 RVA: 0x003CC344 File Offset: 0x003CA544
		// (set) Token: 0x0600D5DF RID: 54751 RVA: 0x003CC34C File Offset: 0x003CA54C
		public int id { get; set; }

		// Token: 0x170012BA RID: 4794
		// (get) Token: 0x0600D5E0 RID: 54752 RVA: 0x003CC355 File Offset: 0x003CA555
		// (set) Token: 0x0600D5E1 RID: 54753 RVA: 0x003CC35D File Offset: 0x003CA55D
		public int index { get; set; }

		// Token: 0x0600D5E2 RID: 54754 RVA: 0x003CC366 File Offset: 0x003CA566
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.index = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
