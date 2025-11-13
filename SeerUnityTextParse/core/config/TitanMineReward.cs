using System;

namespace core.config
{
	// Token: 0x02001E7F RID: 7807
	public class TitanMineReward : XlsConfigBase<TitanMineReward, ITitanMineRewardInfo>
	{
		// Token: 0x17001A47 RID: 6727
		// (get) Token: 0x0600E868 RID: 59496 RVA: 0x003E344D File Offset: 0x003E164D
		public override string fileName
		{
			get
			{
				return "titanMineReward";
			}
		}

		// Token: 0x0600E869 RID: 59497 RVA: 0x003E3454 File Offset: 0x003E1654
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITitanMineRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITitanMineRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E86A RID: 59498 RVA: 0x003E34A8 File Offset: 0x003E16A8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
