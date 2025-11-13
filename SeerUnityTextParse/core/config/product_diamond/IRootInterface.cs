using System;

namespace core.config.product_diamond
{
	// Token: 0x02001F38 RID: 7992
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001BD4 RID: 7124
		// (get) Token: 0x0600EFBA RID: 61370 RVA: 0x003F3F0A File Offset: 0x003F210A
		public override string fileName
		{
			get
			{
				return "product_diamond";
			}
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x0600EFBB RID: 61371 RVA: 0x003F3F11 File Offset: 0x003F2111
		// (set) Token: 0x0600EFBC RID: 61372 RVA: 0x003F3F19 File Offset: 0x003F2119
		public IRoot root { get; set; }

		// Token: 0x0600EFBD RID: 61373 RVA: 0x003F3F22 File Offset: 0x003F2122
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EFBE RID: 61374 RVA: 0x003F3F48 File Offset: 0x003F2148
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
