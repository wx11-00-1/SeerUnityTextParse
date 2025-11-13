using System;

namespace core.config
{
	// Token: 0x02001E87 RID: 7815
	public class WishFloatingBottle : XlsConfigBase<WishFloatingBottle, IWishFloatingBottleInfo>
	{
		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x0600E8A6 RID: 59558 RVA: 0x003E3929 File Offset: 0x003E1B29
		public override string fileName
		{
			get
			{
				return "WishFloatingBottle";
			}
		}

		// Token: 0x0600E8A7 RID: 59559 RVA: 0x003E3930 File Offset: 0x003E1B30
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IWishFloatingBottleInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IWishFloatingBottleInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E8A8 RID: 59560 RVA: 0x003E3984 File Offset: 0x003E1B84
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
