using System;

namespace core.config
{
	// Token: 0x02001E37 RID: 7735
	public class Starmap : XlsConfigBase<Starmap, IStarmapInfo>
	{
		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x0600E534 RID: 58676 RVA: 0x003DF53A File Offset: 0x003DD73A
		public override string fileName
		{
			get
			{
				return "starmap";
			}
		}

		// Token: 0x0600E535 RID: 58677 RVA: 0x003DF544 File Offset: 0x003DD744
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStarmapInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStarmapInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E536 RID: 58678 RVA: 0x003DF598 File Offset: 0x003DD798
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
