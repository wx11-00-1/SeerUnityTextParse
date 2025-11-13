using System;

namespace core.config
{
	// Token: 0x02001DD3 RID: 7635
	public class PveBossExperienceTraining : XlsConfigBase<PveBossExperienceTraining, IPveBossExperienceTrainingInfo>
	{
		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x0600E0EC RID: 57580 RVA: 0x003D9DB3 File Offset: 0x003D7FB3
		public override string fileName
		{
			get
			{
				return "PveBossExperienceTraining";
			}
		}

		// Token: 0x0600E0ED RID: 57581 RVA: 0x003D9DBC File Offset: 0x003D7FBC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPveBossExperienceTrainingInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPveBossExperienceTrainingInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E0EE RID: 57582 RVA: 0x003D9E10 File Offset: 0x003D8010
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
