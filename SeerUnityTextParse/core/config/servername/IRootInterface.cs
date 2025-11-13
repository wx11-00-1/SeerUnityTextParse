using System;

namespace core.config.servername
{
	// Token: 0x02001F2C RID: 7980
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001BAF RID: 7087
		// (get) Token: 0x0600EF58 RID: 61272 RVA: 0x003F37E2 File Offset: 0x003F19E2
		public override string fileName
		{
			get
			{
				return "servername";
			}
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x0600EF59 RID: 61273 RVA: 0x003F37E9 File Offset: 0x003F19E9
		// (set) Token: 0x0600EF5A RID: 61274 RVA: 0x003F37F1 File Offset: 0x003F19F1
		public IRoot root { get; set; }

		// Token: 0x0600EF5B RID: 61275 RVA: 0x003F37FA File Offset: 0x003F19FA
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EF5C RID: 61276 RVA: 0x003F3820 File Offset: 0x003F1A20
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
