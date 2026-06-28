using System;

namespace core.config.WishMintmark
{
	// Token: 0x020028F4 RID: 10484
	public class IWishMintmarks
	{
		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x06015124 RID: 86308 RVA: 0x0057ED5D File Offset: 0x0057CF5D
		// (set) Token: 0x06015125 RID: 86309 RVA: 0x0057ED65 File Offset: 0x0057CF65
		public IWishMintmarkItem[] WishMintmark { get; set; }

		// Token: 0x06015126 RID: 86310 RVA: 0x0057ED70 File Offset: 0x0057CF70
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.WishMintmark = new IWishMintmarkItem[num];
				for (int i = 0; i < num; i++)
				{
					this.WishMintmark[i] = new IWishMintmarkItem();
					this.WishMintmark[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
