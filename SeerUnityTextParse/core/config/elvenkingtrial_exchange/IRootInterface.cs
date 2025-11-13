using System;

namespace core.config.elvenkingtrial_exchange
{
	// Token: 0x02002050 RID: 8272
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x0600FC9D RID: 64669 RVA: 0x0040220C File Offset: 0x0040040C
		public override string fileName
		{
			get
			{
				return "elvenkingtrial_exchange";
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x0600FC9E RID: 64670 RVA: 0x00402213 File Offset: 0x00400413
		// (set) Token: 0x0600FC9F RID: 64671 RVA: 0x0040221B File Offset: 0x0040041B
		public IRoot root { get; set; }

		// Token: 0x0600FCA0 RID: 64672 RVA: 0x00402224 File Offset: 0x00400424
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FCA1 RID: 64673 RVA: 0x00402254 File Offset: 0x00400454
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400F5FD RID: 62973
		private bool b;
	}
}
