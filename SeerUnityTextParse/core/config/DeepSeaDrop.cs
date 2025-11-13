using System;

namespace core.config
{
	// Token: 0x02001D2B RID: 7467
	public class DeepSeaDrop : XlsConfigBase<DeepSeaDrop, IDeepSeaDropInfo>
	{
		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x0600DA24 RID: 55844 RVA: 0x003D15B2 File Offset: 0x003CF7B2
		public override string fileName
		{
			get
			{
				return "deepSeaDrop";
			}
		}

		// Token: 0x0600DA25 RID: 55845 RVA: 0x003D15BC File Offset: 0x003CF7BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDeepSeaDropInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDeepSeaDropInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DA26 RID: 55846 RVA: 0x003D1610 File Offset: 0x003CF810
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
