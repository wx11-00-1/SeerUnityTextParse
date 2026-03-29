using System;

namespace core.config
{
	// Token: 0x02002284 RID: 8836
	public class LatestActivityTemp : XlsConfigBase<LatestActivityTemp, ILatestActivityTempInfo>
	{
		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x06010B40 RID: 68416 RVA: 0x0048E979 File Offset: 0x0048CB79
		public override string fileName
		{
			get
			{
				return "latestActivity_temp";
			}
		}

		// Token: 0x06010B41 RID: 68417 RVA: 0x0048E980 File Offset: 0x0048CB80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILatestActivityTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILatestActivityTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06010B42 RID: 68418 RVA: 0x0048E9D4 File Offset: 0x0048CBD4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
