using System;

namespace core.config.newer_guide_h5
{
	// Token: 0x02001F97 RID: 8087
	public class IRoot
	{
		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x0600F2CE RID: 62158 RVA: 0x003F7B11 File Offset: 0x003F5D11
		// (set) Token: 0x0600F2CF RID: 62159 RVA: 0x003F7B19 File Offset: 0x003F5D19
		public IStepsItem[] steps { get; set; }

		// Token: 0x0600F2D0 RID: 62160 RVA: 0x003F7B24 File Offset: 0x003F5D24
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
