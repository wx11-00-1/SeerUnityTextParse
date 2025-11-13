using System;

namespace core.config
{
	// Token: 0x02001D49 RID: 7497
	public class FestivalVersionConfig : XlsConfigBase<FestivalVersionConfig, IFestivalVersionConfigInfo>
	{
		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x0600DB52 RID: 56146 RVA: 0x003D2BBE File Offset: 0x003D0DBE
		public override string fileName
		{
			get
			{
				return "festival_version_config";
			}
		}

		// Token: 0x0600DB53 RID: 56147 RVA: 0x003D2BC8 File Offset: 0x003D0DC8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFestivalVersionConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFestivalVersionConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DB54 RID: 56148 RVA: 0x003D2C1C File Offset: 0x003D0E1C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
