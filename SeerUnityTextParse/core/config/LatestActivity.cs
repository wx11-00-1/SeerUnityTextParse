using System;

namespace core.config
{
	// Token: 0x02001D71 RID: 7537
	public class LatestActivity : XlsConfigBase<LatestActivity, ILatestActivityInfo>
	{
		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x0600DCD2 RID: 56530 RVA: 0x003D4CA6 File Offset: 0x003D2EA6
		public override string fileName
		{
			get
			{
				return "latestActivity";
			}
		}

		// Token: 0x0600DCD3 RID: 56531 RVA: 0x003D4CB0 File Offset: 0x003D2EB0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILatestActivityInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILatestActivityInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DCD4 RID: 56532 RVA: 0x003D4D04 File Offset: 0x003D2F04
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
