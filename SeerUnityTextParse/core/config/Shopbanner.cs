using System;

namespace core.config
{
	// Token: 0x02002358 RID: 9048
	public class Shopbanner : XlsConfigBase<Shopbanner, IShopbannerInfo>
	{
		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06011466 RID: 70758 RVA: 0x00499EF0 File Offset: 0x004980F0
		public override string fileName
		{
			get
			{
				return "shopbanner";
			}
		}

		// Token: 0x06011467 RID: 70759 RVA: 0x00499EF8 File Offset: 0x004980F8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IShopbannerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IShopbannerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011468 RID: 70760 RVA: 0x00499F4C File Offset: 0x0049814C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
