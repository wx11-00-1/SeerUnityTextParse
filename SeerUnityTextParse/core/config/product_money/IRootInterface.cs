using System;

namespace core.config.product_money
{
	// Token: 0x02001F35 RID: 7989
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001BCB RID: 7115
		// (get) Token: 0x0600EFA2 RID: 61346 RVA: 0x003F3D3A File Offset: 0x003F1F3A
		public override string fileName
		{
			get
			{
				return "product_money";
			}
		}

		// Token: 0x17001BCC RID: 7116
		// (get) Token: 0x0600EFA3 RID: 61347 RVA: 0x003F3D41 File Offset: 0x003F1F41
		// (set) Token: 0x0600EFA4 RID: 61348 RVA: 0x003F3D49 File Offset: 0x003F1F49
		public IRoot root { get; set; }

		// Token: 0x0600EFA5 RID: 61349 RVA: 0x003F3D52 File Offset: 0x003F1F52
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EFA6 RID: 61350 RVA: 0x003F3D78 File Offset: 0x003F1F78
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
