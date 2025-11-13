using System;

namespace core.config
{
	// Token: 0x02001DDD RID: 7645
	public class PvpExpertSeasonrank : XlsConfigBase<PvpExpertSeasonrank, IPvpExpertSeasonrankInfo>
	{
		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x0600E148 RID: 57672 RVA: 0x003DA5A3 File Offset: 0x003D87A3
		public override string fileName
		{
			get
			{
				return "pvp_expert_seasonrank";
			}
		}

		// Token: 0x0600E149 RID: 57673 RVA: 0x003DA5AC File Offset: 0x003D87AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpExpertSeasonrankInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpExpertSeasonrankInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E14A RID: 57674 RVA: 0x003DA600 File Offset: 0x003D8800
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
