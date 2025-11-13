using System;

namespace core.config.aimat
{
	// Token: 0x02002077 RID: 8311
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x0600FDC7 RID: 64967 RVA: 0x004037E2 File Offset: 0x004019E2
		public override string fileName
		{
			get
			{
				return "aimat";
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x0600FDC8 RID: 64968 RVA: 0x004037E9 File Offset: 0x004019E9
		// (set) Token: 0x0600FDC9 RID: 64969 RVA: 0x004037F1 File Offset: 0x004019F1
		public IRoot root { get; set; }

		// Token: 0x0600FDCA RID: 64970 RVA: 0x004037FA File Offset: 0x004019FA
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FDCB RID: 64971 RVA: 0x00403820 File Offset: 0x00401A20
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
