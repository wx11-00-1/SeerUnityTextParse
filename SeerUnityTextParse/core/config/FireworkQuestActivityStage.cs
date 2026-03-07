using System;

namespace core.config
{
	// Token: 0x02001FDC RID: 8156
	public class FireworkQuestActivityStage : XlsConfigBase<FireworkQuestActivityStage, IFireworkQuestActivityStageInfo>
	{
		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x0600F4A8 RID: 62632 RVA: 0x004381B3 File Offset: 0x004363B3
		public override string fileName
		{
			get
			{
				return "fireworkQuestActivityStage";
			}
		}

		// Token: 0x0600F4A9 RID: 62633 RVA: 0x004381BC File Offset: 0x004363BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFireworkQuestActivityStageInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFireworkQuestActivityStageInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F4AA RID: 62634 RVA: 0x00438210 File Offset: 0x00436410
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
