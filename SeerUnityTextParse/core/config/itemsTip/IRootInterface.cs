using System;

namespace core.config.itemsTip
{
	// Token: 0x02001FE4 RID: 8164
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x0600F5FF RID: 62975 RVA: 0x003FB83E File Offset: 0x003F9A3E
		public override string fileName
		{
			get
			{
				return "itemsTip";
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x0600F600 RID: 62976 RVA: 0x003FB845 File Offset: 0x003F9A45
		// (set) Token: 0x0600F601 RID: 62977 RVA: 0x003FB84D File Offset: 0x003F9A4D
		public IRoot root { get; set; }

		// Token: 0x0600F602 RID: 62978 RVA: 0x003FB856 File Offset: 0x003F9A56
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F603 RID: 62979 RVA: 0x003FB87C File Offset: 0x003F9A7C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
