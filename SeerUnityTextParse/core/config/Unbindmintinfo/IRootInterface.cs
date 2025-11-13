using System;

namespace core.config.Unbindmintinfo
{
	// Token: 0x02001F01 RID: 7937
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x0600EDB0 RID: 60848 RVA: 0x003F1854 File Offset: 0x003EFA54
		public override string fileName
		{
			get
			{
				return "Unbindmintinfo";
			}
		}

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x0600EDB1 RID: 60849 RVA: 0x003F185B File Offset: 0x003EFA5B
		// (set) Token: 0x0600EDB2 RID: 60850 RVA: 0x003F1863 File Offset: 0x003EFA63
		public IRoot Root { get; set; }

		// Token: 0x0600EDB3 RID: 60851 RVA: 0x003F186C File Offset: 0x003EFA6C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Root = new IRoot();
				this.Root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EDB4 RID: 60852 RVA: 0x003F1890 File Offset: 0x003EFA90
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
