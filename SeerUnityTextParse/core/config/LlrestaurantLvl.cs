using System;

namespace core.config
{
	// Token: 0x02001D7D RID: 7549
	public class LlrestaurantLvl : XlsConfigBase<LlrestaurantLvl, ILlrestaurantLvlInfo>
	{
		// Token: 0x170015B5 RID: 5557
		// (get) Token: 0x0600DD40 RID: 56640 RVA: 0x003D54DC File Offset: 0x003D36DC
		public override string fileName
		{
			get
			{
				return "llrestaurant_lvl";
			}
		}

		// Token: 0x0600DD41 RID: 56641 RVA: 0x003D54E4 File Offset: 0x003D36E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILlrestaurantLvlInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILlrestaurantLvlInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DD42 RID: 56642 RVA: 0x003D5538 File Offset: 0x003D3738
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
