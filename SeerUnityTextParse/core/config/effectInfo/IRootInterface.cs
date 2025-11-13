using System;

namespace core.config.effectInfo
{
	// Token: 0x02002056 RID: 8278
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x0600FCC3 RID: 64707 RVA: 0x00402503 File Offset: 0x00400703
		public override string fileName
		{
			get
			{
				return "effectInfo";
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x0600FCC4 RID: 64708 RVA: 0x0040250A File Offset: 0x0040070A
		// (set) Token: 0x0600FCC5 RID: 64709 RVA: 0x00402512 File Offset: 0x00400712
		public IRoot root { get; set; }

		// Token: 0x0600FCC6 RID: 64710 RVA: 0x0040251B File Offset: 0x0040071B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FCC7 RID: 64711 RVA: 0x00402540 File Offset: 0x00400740
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
