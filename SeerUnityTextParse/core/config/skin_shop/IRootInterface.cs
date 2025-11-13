using System;

namespace core.config.skin_shop
{
	// Token: 0x02001F1D RID: 7965
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x0600EE9E RID: 61086 RVA: 0x003F29C3 File Offset: 0x003F0BC3
		public override string fileName
		{
			get
			{
				return "skin_shop";
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x0600EE9F RID: 61087 RVA: 0x003F29CA File Offset: 0x003F0BCA
		// (set) Token: 0x0600EEA0 RID: 61088 RVA: 0x003F29D2 File Offset: 0x003F0BD2
		public IRoot root { get; set; }

		// Token: 0x0600EEA1 RID: 61089 RVA: 0x003F29DB File Offset: 0x003F0BDB
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EEA2 RID: 61090 RVA: 0x003F2A00 File Offset: 0x003F0C00
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
