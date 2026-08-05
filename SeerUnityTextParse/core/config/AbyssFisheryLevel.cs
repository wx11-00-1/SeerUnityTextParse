using System;

namespace core.config
{
	// Token: 0x020026B2 RID: 9906
	public class AbyssFisheryLevel : XlsConfigBase<AbyssFisheryLevel, IAbyssFisheryLevelInfo>
	{
		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x0601378D RID: 79757 RVA: 0x0058394B File Offset: 0x00581B4B
		public override string fileName
		{
			get
			{
				return "AbyssFisheryLevel";
			}
		}

		// Token: 0x0601378E RID: 79758 RVA: 0x00583954 File Offset: 0x00581B54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAbyssFisheryLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAbyssFisheryLevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601378F RID: 79759 RVA: 0x005839A8 File Offset: 0x00581BA8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
