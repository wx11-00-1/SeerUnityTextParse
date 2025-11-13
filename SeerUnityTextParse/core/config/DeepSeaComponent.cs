using System;

namespace core.config
{
	// Token: 0x02001D29 RID: 7465
	public class DeepSeaComponent : XlsConfigBase<DeepSeaComponent, IDeepSeaComponentInfo>
	{
		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x0600DA0E RID: 55822 RVA: 0x003D141B File Offset: 0x003CF61B
		public override string fileName
		{
			get
			{
				return "deepSeaComponent";
			}
		}

		// Token: 0x0600DA0F RID: 55823 RVA: 0x003D1424 File Offset: 0x003CF624
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDeepSeaComponentInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDeepSeaComponentInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DA10 RID: 55824 RVA: 0x003D1478 File Offset: 0x003CF678
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
