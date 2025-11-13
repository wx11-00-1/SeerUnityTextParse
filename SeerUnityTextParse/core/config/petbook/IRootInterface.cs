using System;

namespace core.config.petbook
{
	// Token: 0x02001F70 RID: 8048
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x0600F18C RID: 61836 RVA: 0x003F63CD File Offset: 0x003F45CD
		public override string fileName
		{
			get
			{
				return "petbook";
			}
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x0600F18D RID: 61837 RVA: 0x003F63D4 File Offset: 0x003F45D4
		// (set) Token: 0x0600F18E RID: 61838 RVA: 0x003F63DC File Offset: 0x003F45DC
		public IRoot root { get; set; }

		// Token: 0x0600F18F RID: 61839 RVA: 0x003F63E5 File Offset: 0x003F45E5
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F190 RID: 61840 RVA: 0x003F6408 File Offset: 0x003F4608
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
