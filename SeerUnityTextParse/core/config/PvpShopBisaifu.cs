using System;

namespace core.config
{
	// Token: 0x02001DE5 RID: 7653
	public class PvpShopBisaifu : XlsConfigBase<PvpShopBisaifu, IPvpShopBisaifuInfo>
	{
		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x0600E1A2 RID: 57762 RVA: 0x003DABE9 File Offset: 0x003D8DE9
		public override string fileName
		{
			get
			{
				return "pvp_shop_bisaifu";
			}
		}

		// Token: 0x0600E1A3 RID: 57763 RVA: 0x003DABF0 File Offset: 0x003D8DF0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpShopBisaifuInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpShopBisaifuInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E1A4 RID: 57764 RVA: 0x003DAC44 File Offset: 0x003D8E44
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
