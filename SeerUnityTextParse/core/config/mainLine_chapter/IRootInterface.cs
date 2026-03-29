using System;

namespace core.config.mainLine_chapter
{
	// Token: 0x0200257B RID: 9595
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002610 RID: 9744
		// (get) Token: 0x06012A73 RID: 76403 RVA: 0x004BDBEE File Offset: 0x004BBDEE
		public override string fileName
		{
			get
			{
				return "mainLine_chapter";
			}
		}

		// Token: 0x17002611 RID: 9745
		// (get) Token: 0x06012A74 RID: 76404 RVA: 0x004BDBF5 File Offset: 0x004BBDF5
		// (set) Token: 0x06012A75 RID: 76405 RVA: 0x004BDBFD File Offset: 0x004BBDFD
		public IRoot root { get; set; }

		// Token: 0x06012A76 RID: 76406 RVA: 0x004BDC06 File Offset: 0x004BBE06
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06012A77 RID: 76407 RVA: 0x004BDC2C File Offset: 0x004BBE2C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
