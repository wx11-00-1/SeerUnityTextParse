using System;

namespace core.config
{
	// Token: 0x02001E85 RID: 7813
	public class Vipsonstellationsuit : XlsConfigBase<Vipsonstellationsuit, IVipsonstellationsuitInfo>
	{
		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x0600E896 RID: 59542 RVA: 0x003E37F6 File Offset: 0x003E19F6
		public override string fileName
		{
			get
			{
				return "Vipsonstellationsuit";
			}
		}

		// Token: 0x0600E897 RID: 59543 RVA: 0x003E3800 File Offset: 0x003E1A00
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IVipsonstellationsuitInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IVipsonstellationsuitInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E898 RID: 59544 RVA: 0x003E3854 File Offset: 0x003E1A54
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
