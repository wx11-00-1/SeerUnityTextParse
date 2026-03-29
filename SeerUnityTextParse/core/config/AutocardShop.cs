using System;

namespace core.config
{
	// Token: 0x02002140 RID: 8512
	public class AutocardShop : XlsConfigBase<AutocardShop, IAutocardShopInfo>
	{
		// Token: 0x17001504 RID: 5380
		// (get) Token: 0x0600FD08 RID: 64776 RVA: 0x0047D8EB File Offset: 0x0047BAEB
		public override string fileName
		{
			get
			{
				return "autocardShop";
			}
		}

		// Token: 0x0600FD09 RID: 64777 RVA: 0x0047D8F4 File Offset: 0x0047BAF4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FD0A RID: 64778 RVA: 0x0047D948 File Offset: 0x0047BB48
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
