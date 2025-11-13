using System;

namespace core.config
{
	// Token: 0x02001DD5 RID: 7637
	public class PveBossLearningTraining : XlsConfigBase<PveBossLearningTraining, IPveBossLearningTrainingInfo>
	{
		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x0600E0FE RID: 57598 RVA: 0x003D9F8B File Offset: 0x003D818B
		public override string fileName
		{
			get
			{
				return "PveBossLearningTraining";
			}
		}

		// Token: 0x0600E0FF RID: 57599 RVA: 0x003D9F94 File Offset: 0x003D8194
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPveBossLearningTrainingInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPveBossLearningTrainingInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E100 RID: 57600 RVA: 0x003D9FE8 File Offset: 0x003D81E8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
