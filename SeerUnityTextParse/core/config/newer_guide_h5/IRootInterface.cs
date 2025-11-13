using System;

namespace core.config.newer_guide_h5
{
	// Token: 0x02001F98 RID: 8088
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x0600F2D2 RID: 62162 RVA: 0x003F7B7E File Offset: 0x003F5D7E
		public override string fileName
		{
			get
			{
				return "newer_guide_h5";
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x0600F2D3 RID: 62163 RVA: 0x003F7B85 File Offset: 0x003F5D85
		// (set) Token: 0x0600F2D4 RID: 62164 RVA: 0x003F7B8D File Offset: 0x003F5D8D
		public IRoot root { get; set; }

		// Token: 0x0600F2D5 RID: 62165 RVA: 0x003F7B96 File Offset: 0x003F5D96
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F2D6 RID: 62166 RVA: 0x003F7BBC File Offset: 0x003F5DBC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
