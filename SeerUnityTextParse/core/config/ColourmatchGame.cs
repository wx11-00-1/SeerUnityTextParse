using System;

namespace core.config
{
	// Token: 0x02001D09 RID: 7433
	public class ColourmatchGame : XlsConfigBase<ColourmatchGame, IColourmatchGameInfo>
	{
		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x0600D8E2 RID: 55522 RVA: 0x003CFD47 File Offset: 0x003CDF47
		public override string fileName
		{
			get
			{
				return "colourmatchGame";
			}
		}

		// Token: 0x0600D8E3 RID: 55523 RVA: 0x003CFD50 File Offset: 0x003CDF50
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IColourmatchGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IColourmatchGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D8E4 RID: 55524 RVA: 0x003CFDA4 File Offset: 0x003CDFA4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
