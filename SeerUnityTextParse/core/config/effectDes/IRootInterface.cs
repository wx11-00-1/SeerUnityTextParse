using System;

namespace core.config.effectDes
{
	// Token: 0x0200205C RID: 8284
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x0600FD0B RID: 64779 RVA: 0x00402ABE File Offset: 0x00400CBE
		public override string fileName
		{
			get
			{
				return "effectDes";
			}
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x0600FD0C RID: 64780 RVA: 0x00402AC5 File Offset: 0x00400CC5
		// (set) Token: 0x0600FD0D RID: 64781 RVA: 0x00402ACD File Offset: 0x00400CCD
		public IRoot root { get; set; }

		// Token: 0x0600FD0E RID: 64782 RVA: 0x00402AD6 File Offset: 0x00400CD6
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FD0F RID: 64783 RVA: 0x00402AFC File Offset: 0x00400CFC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
