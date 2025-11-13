using System;

namespace core.config.Attireconversion
{
	// Token: 0x02002074 RID: 8308
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x0600FDB3 RID: 64947 RVA: 0x00403696 File Offset: 0x00401896
		public override string fileName
		{
			get
			{
				return "Attireconversion";
			}
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x0600FDB4 RID: 64948 RVA: 0x0040369D File Offset: 0x0040189D
		// (set) Token: 0x0600FDB5 RID: 64949 RVA: 0x004036A5 File Offset: 0x004018A5
		public IAttireconversions Attireconversions { get; set; }

		// Token: 0x0600FDB6 RID: 64950 RVA: 0x004036AE File Offset: 0x004018AE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Attireconversions = new IAttireconversions();
				this.Attireconversions.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FDB7 RID: 64951 RVA: 0x004036D4 File Offset: 0x004018D4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
