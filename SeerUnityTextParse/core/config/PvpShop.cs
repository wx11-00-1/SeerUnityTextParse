using System;

namespace core.config
{
	// Token: 0x02001DE3 RID: 7651
	public class PvpShop : XlsConfigBase<PvpShop, IPvpShopInfo>
	{
		// Token: 0x1700176F RID: 5999
		// (get) Token: 0x0600E180 RID: 57728 RVA: 0x003DA9A5 File Offset: 0x003D8BA5
		public override string fileName
		{
			get
			{
				return "pvp_shop";
			}
		}

		// Token: 0x0600E181 RID: 57729 RVA: 0x003DA9AC File Offset: 0x003D8BAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E182 RID: 57730 RVA: 0x003DAA00 File Offset: 0x003D8C00
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
