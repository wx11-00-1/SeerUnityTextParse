using System;

namespace core.config.WishMintmark
{
	// Token: 0x020028F2 RID: 10482
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x06015114 RID: 86292 RVA: 0x0057EC76 File Offset: 0x0057CE76
		public override string fileName
		{
			get
			{
				return "WishMintmark";
			}
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x06015115 RID: 86293 RVA: 0x0057EC7D File Offset: 0x0057CE7D
		// (set) Token: 0x06015116 RID: 86294 RVA: 0x0057EC85 File Offset: 0x0057CE85
		public IWishMintmarks WishMintmarks { get; set; }

		// Token: 0x06015117 RID: 86295 RVA: 0x0057EC8E File Offset: 0x0057CE8E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.WishMintmarks = new IWishMintmarks();
				this.WishMintmarks.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06015118 RID: 86296 RVA: 0x0057ECB4 File Offset: 0x0057CEB4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
