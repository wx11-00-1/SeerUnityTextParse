using System;

namespace core.config
{
	// Token: 0x020023F0 RID: 9200
	public class TutorialTalk : XlsConfigBase<TutorialTalk, ITutorialTalkInfo>
	{
		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06011B58 RID: 72536 RVA: 0x004A26FC File Offset: 0x004A08FC
		public override string fileName
		{
			get
			{
				return "tutorial_talk";
			}
		}

		// Token: 0x06011B59 RID: 72537 RVA: 0x004A2704 File Offset: 0x004A0904
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITutorialTalkInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITutorialTalkInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011B5A RID: 72538 RVA: 0x004A2758 File Offset: 0x004A0958
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
