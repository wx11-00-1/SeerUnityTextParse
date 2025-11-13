using System;

namespace core.config.newer_guide_h5_2
{
	// Token: 0x02001F95 RID: 8085
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x0600F2B2 RID: 62130 RVA: 0x003F7924 File Offset: 0x003F5B24
		public override string fileName
		{
			get
			{
				return "newer_guide_h5_2";
			}
		}

		// Token: 0x17001CF4 RID: 7412
		// (get) Token: 0x0600F2B3 RID: 62131 RVA: 0x003F792B File Offset: 0x003F5B2B
		// (set) Token: 0x0600F2B4 RID: 62132 RVA: 0x003F7933 File Offset: 0x003F5B33
		public IRoot root { get; set; }

		// Token: 0x0600F2B5 RID: 62133 RVA: 0x003F793C File Offset: 0x003F5B3C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F2B6 RID: 62134 RVA: 0x003F7960 File Offset: 0x003F5B60
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
