using System;

namespace core.config
{
	// Token: 0x02002116 RID: 8470
	public class AdAstraShop : XlsConfigBase<AdAstraShop, IAdAstraShopInfo>
	{
		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x0600FB4E RID: 64334 RVA: 0x0047B82F File Offset: 0x00479A2F
		public override string fileName
		{
			get
			{
				return "AdAstraShop";
			}
		}

		// Token: 0x0600FB4F RID: 64335 RVA: 0x0047B838 File Offset: 0x00479A38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAdAstraShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAdAstraShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FB50 RID: 64336 RVA: 0x0047B88C File Offset: 0x00479A8C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
