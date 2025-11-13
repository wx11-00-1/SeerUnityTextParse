using System;

namespace core.config
{
	// Token: 0x02001D67 RID: 7527
	public class HelpTips : XlsConfigBase<HelpTips, IHelpTipsInfo>
	{
		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x0600DC7E RID: 56446 RVA: 0x003D465C File Offset: 0x003D285C
		public override string fileName
		{
			get
			{
				return "help_tips";
			}
		}

		// Token: 0x0600DC7F RID: 56447 RVA: 0x003D4664 File Offset: 0x003D2864
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IHelpTipsInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IHelpTipsInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DC80 RID: 56448 RVA: 0x003D46B8 File Offset: 0x003D28B8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
