using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F65 RID: 8037
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x0600F12E RID: 61742 RVA: 0x003F5C29 File Offset: 0x003F3E29
		public override string fileName
		{
			get
			{
				return "petbook_bisaifu";
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x0600F12F RID: 61743 RVA: 0x003F5C30 File Offset: 0x003F3E30
		// (set) Token: 0x0600F130 RID: 61744 RVA: 0x003F5C38 File Offset: 0x003F3E38
		public IRoot root { get; set; }

		// Token: 0x0600F131 RID: 61745 RVA: 0x003F5C41 File Offset: 0x003F3E41
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F132 RID: 61746 RVA: 0x003F5C64 File Offset: 0x003F3E64
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
