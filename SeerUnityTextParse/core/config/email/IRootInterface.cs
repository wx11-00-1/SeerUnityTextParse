using System;

namespace core.config.email
{
	// Token: 0x0200204A RID: 8266
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x0600FC67 RID: 64615 RVA: 0x00401DDA File Offset: 0x003FFFDA
		public override string fileName
		{
			get
			{
				return "email";
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x0600FC68 RID: 64616 RVA: 0x00401DE1 File Offset: 0x003FFFE1
		// (set) Token: 0x0600FC69 RID: 64617 RVA: 0x00401DE9 File Offset: 0x003FFFE9
		public IRoot root { get; set; }

		// Token: 0x0600FC6A RID: 64618 RVA: 0x00401DF2 File Offset: 0x003FFFF2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FC6B RID: 64619 RVA: 0x00401E18 File Offset: 0x00400018
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
