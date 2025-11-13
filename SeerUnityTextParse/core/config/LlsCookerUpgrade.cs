using System;

namespace core.config
{
	// Token: 0x02001D7F RID: 7551
	public class LlsCookerUpgrade : XlsConfigBase<LlsCookerUpgrade, ILlsCookerUpgradeInfo>
	{
		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x0600DD4C RID: 56652 RVA: 0x003D55BC File Offset: 0x003D37BC
		public override string fileName
		{
			get
			{
				return "lls_cooker_upgrade";
			}
		}

		// Token: 0x0600DD4D RID: 56653 RVA: 0x003D55C4 File Offset: 0x003D37C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILlsCookerUpgradeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILlsCookerUpgradeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DD4E RID: 56654 RVA: 0x003D5618 File Offset: 0x003D3818
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
