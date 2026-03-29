using System;

namespace core.config.newguideStep2020
{
	// Token: 0x0200252C RID: 9516
	public class IRoot
	{
		// Token: 0x170024B1 RID: 9393
		// (get) Token: 0x06012712 RID: 75538 RVA: 0x004B9378 File Offset: 0x004B7578
		// (set) Token: 0x06012713 RID: 75539 RVA: 0x004B9380 File Offset: 0x004B7580
		public IStepsItem[] steps { get; set; }

		// Token: 0x06012714 RID: 75540 RVA: 0x004B938C File Offset: 0x004B758C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.steps = new IStepsItem[num];
				for (int i = 0; i < num; i++)
				{
					this.steps[i] = new IStepsItem();
					this.steps[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
