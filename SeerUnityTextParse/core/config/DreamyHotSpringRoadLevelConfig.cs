using System;

namespace core.config
{
	// Token: 0x02001D33 RID: 7475
	public class DreamyHotSpringRoadLevelConfig : XlsConfigBase<DreamyHotSpringRoadLevelConfig, IDreamyHotSpringRoadLevelConfigInfo>
	{
		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x0600DA64 RID: 55908 RVA: 0x003D1AAE File Offset: 0x003CFCAE
		public override string fileName
		{
			get
			{
				return "dreamyHotSpringRoadLevelConfig";
			}
		}

		// Token: 0x0600DA65 RID: 55909 RVA: 0x003D1AB8 File Offset: 0x003CFCB8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDreamyHotSpringRoadLevelConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDreamyHotSpringRoadLevelConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DA66 RID: 55910 RVA: 0x003D1B0C File Offset: 0x003CFD0C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
