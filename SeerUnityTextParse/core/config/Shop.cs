using System;

namespace core.config
{
	// Token: 0x02001E13 RID: 7699
	public class Shop : XlsConfigBase<Shop, IShopInfo>
	{
		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x0600E382 RID: 58242 RVA: 0x003DD2B5 File Offset: 0x003DB4B5
		public override string fileName
		{
			get
			{
				return "shop";
			}
		}

		// Token: 0x0600E383 RID: 58243 RVA: 0x003DD2BC File Offset: 0x003DB4BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IShopInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IShopInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E384 RID: 58244 RVA: 0x003DD310 File Offset: 0x003DB510
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
