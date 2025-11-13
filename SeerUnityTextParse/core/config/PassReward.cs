using System;

namespace core.config
{
	// Token: 0x02001DB7 RID: 7607
	public class PassReward : XlsConfigBase<PassReward, IPassRewardInfo>
	{
		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x0600DFC8 RID: 57288 RVA: 0x003D881A File Offset: 0x003D6A1A
		public override string fileName
		{
			get
			{
				return "pass_reward";
			}
		}

		// Token: 0x0600DFC9 RID: 57289 RVA: 0x003D8824 File Offset: 0x003D6A24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPassRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPassRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DFCA RID: 57290 RVA: 0x003D8878 File Offset: 0x003D6A78
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
