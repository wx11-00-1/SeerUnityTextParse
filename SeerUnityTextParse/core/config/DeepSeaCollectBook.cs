using System;

namespace core.config
{
	// Token: 0x02001D27 RID: 7463
	public class DeepSeaCollectBook : XlsConfigBase<DeepSeaCollectBook, IDeepSeaCollectBookInfo>
	{
		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x0600D9FC RID: 55804 RVA: 0x003D12B9 File Offset: 0x003CF4B9
		public override string fileName
		{
			get
			{
				return "deepSeaCollectBook";
			}
		}

		// Token: 0x0600D9FD RID: 55805 RVA: 0x003D12C0 File Offset: 0x003CF4C0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDeepSeaCollectBookInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDeepSeaCollectBookInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D9FE RID: 55806 RVA: 0x003D1314 File Offset: 0x003CF514
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
