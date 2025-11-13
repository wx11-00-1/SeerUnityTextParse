using System;

namespace core.config.Monsterpool
{
	// Token: 0x02001FBC RID: 8124
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x0600F4CA RID: 62666 RVA: 0x003FA112 File Offset: 0x003F8312
		public override string fileName
		{
			get
			{
				return "Monsterpool";
			}
		}

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x0600F4CB RID: 62667 RVA: 0x003FA119 File Offset: 0x003F8319
		// (set) Token: 0x0600F4CC RID: 62668 RVA: 0x003FA121 File Offset: 0x003F8321
		public IRoot Root { get; set; }

		// Token: 0x0600F4CD RID: 62669 RVA: 0x003FA12A File Offset: 0x003F832A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Root = new IRoot();
				this.Root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F4CE RID: 62670 RVA: 0x003FA150 File Offset: 0x003F8350
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
