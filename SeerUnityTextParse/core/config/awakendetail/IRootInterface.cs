using System;

namespace core.config.awakendetail
{
	// Token: 0x0200206C RID: 8300
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x0600FD77 RID: 64887 RVA: 0x0040328A File Offset: 0x0040148A
		public override string fileName
		{
			get
			{
				return "awakendetail";
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x0600FD78 RID: 64888 RVA: 0x00403291 File Offset: 0x00401491
		// (set) Token: 0x0600FD79 RID: 64889 RVA: 0x00403299 File Offset: 0x00401499
		public IRoot root { get; set; }

		// Token: 0x0600FD7A RID: 64890 RVA: 0x004032A2 File Offset: 0x004014A2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FD7B RID: 64891 RVA: 0x004032C8 File Offset: 0x004014C8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
