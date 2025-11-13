using System;

namespace core.config
{
	// Token: 0x02001CD8 RID: 7384
	public class IBraveTowerReverseDefenseTyperelationInfo : IConfigItem
	{
		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x0600D662 RID: 54882 RVA: 0x003CCD30 File Offset: 0x003CAF30
		// (set) Token: 0x0600D663 RID: 54883 RVA: 0x003CCD38 File Offset: 0x003CAF38
		public int id { get; set; }

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x0600D664 RID: 54884 RVA: 0x003CCD41 File Offset: 0x003CAF41
		// (set) Token: 0x0600D665 RID: 54885 RVA: 0x003CCD49 File Offset: 0x003CAF49
		public int typeid { get; set; }

		// Token: 0x0600D666 RID: 54886 RVA: 0x003CCD52 File Offset: 0x003CAF52
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.typeid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
