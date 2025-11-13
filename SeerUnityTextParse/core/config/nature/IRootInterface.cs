using System;

namespace core.config.nature
{
	// Token: 0x02001F9D RID: 8093
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x0600F33E RID: 62270 RVA: 0x003F837A File Offset: 0x003F657A
		public override string fileName
		{
			get
			{
				return "nature";
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x0600F33F RID: 62271 RVA: 0x003F8381 File Offset: 0x003F6581
		// (set) Token: 0x0600F340 RID: 62272 RVA: 0x003F8389 File Offset: 0x003F6589
		public IRoot root { get; set; }

		// Token: 0x0600F341 RID: 62273 RVA: 0x003F8392 File Offset: 0x003F6592
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F342 RID: 62274 RVA: 0x003F83B8 File Offset: 0x003F65B8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
