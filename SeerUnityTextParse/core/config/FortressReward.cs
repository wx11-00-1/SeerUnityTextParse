using System;

namespace core.config
{
	// Token: 0x02001D57 RID: 7511
	public class FortressReward : XlsConfigBase<FortressReward, IFortressRewardInfo>
	{
		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x0600DBF2 RID: 56306 RVA: 0x003D3A76 File Offset: 0x003D1C76
		public override string fileName
		{
			get
			{
				return "fortressReward";
			}
		}

		// Token: 0x0600DBF3 RID: 56307 RVA: 0x003D3A80 File Offset: 0x003D1C80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFortressRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFortressRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DBF4 RID: 56308 RVA: 0x003D3AD4 File Offset: 0x003D1CD4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
