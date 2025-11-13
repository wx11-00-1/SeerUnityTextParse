using System;

namespace core.config
{
	// Token: 0x02001DC1 RID: 7617
	public class PetSkinReward : XlsConfigBase<PetSkinReward, IPetSkinRewardInfo>
	{
		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x0600E02C RID: 57388 RVA: 0x003D8F2B File Offset: 0x003D712B
		public override string fileName
		{
			get
			{
				return "pet_skin_reward";
			}
		}

		// Token: 0x0600E02D RID: 57389 RVA: 0x003D8F34 File Offset: 0x003D7134
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPetSkinRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPetSkinRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E02E RID: 57390 RVA: 0x003D8F88 File Offset: 0x003D7188
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
