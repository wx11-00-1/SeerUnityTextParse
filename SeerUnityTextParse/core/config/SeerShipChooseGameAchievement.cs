using System;

namespace core.config
{
	// Token: 0x020027BC RID: 10172
	public class SeerShipChooseGameAchievement : XlsConfigBase<SeerShipChooseGameAchievement, ISeerShipChooseGameAchievementInfo>
	{
		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x06014323 RID: 82723 RVA: 0x00565650 File Offset: 0x00563850
		public override string fileName
		{
			get
			{
				return "seerShipChooseGameAchievement";
			}
		}

		// Token: 0x06014324 RID: 82724 RVA: 0x00565658 File Offset: 0x00563858
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISeerShipChooseGameAchievementInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISeerShipChooseGameAchievementInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014325 RID: 82725 RVA: 0x005656AC File Offset: 0x005638AC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
