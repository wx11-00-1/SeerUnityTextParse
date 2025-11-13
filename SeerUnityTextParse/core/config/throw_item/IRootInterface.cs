using System;

namespace core.config.throw_item
{
	// Token: 0x02001F11 RID: 7953
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x0600EE28 RID: 60968 RVA: 0x003F216A File Offset: 0x003F036A
		public override string fileName
		{
			get
			{
				return "throw_item";
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x0600EE29 RID: 60969 RVA: 0x003F2171 File Offset: 0x003F0371
		// (set) Token: 0x0600EE2A RID: 60970 RVA: 0x003F2179 File Offset: 0x003F0379
		public IRoot root { get; set; }

		// Token: 0x0600EE2B RID: 60971 RVA: 0x003F2182 File Offset: 0x003F0382
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EE2C RID: 60972 RVA: 0x003F21A8 File Offset: 0x003F03A8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
