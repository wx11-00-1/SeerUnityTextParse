using System;

namespace core.config.itemType
{
	// Token: 0x02001FE1 RID: 8161
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E43 RID: 7747
		// (get) Token: 0x0600F5EF RID: 62959 RVA: 0x003FB726 File Offset: 0x003F9926
		public override string fileName
		{
			get
			{
				return "itemType";
			}
		}

		// Token: 0x17001E44 RID: 7748
		// (get) Token: 0x0600F5F0 RID: 62960 RVA: 0x003FB72D File Offset: 0x003F992D
		// (set) Token: 0x0600F5F1 RID: 62961 RVA: 0x003FB735 File Offset: 0x003F9935
		public IRoot root { get; set; }

		// Token: 0x0600F5F2 RID: 62962 RVA: 0x003FB73E File Offset: 0x003F993E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F5F3 RID: 62963 RVA: 0x003FB764 File Offset: 0x003F9964
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
