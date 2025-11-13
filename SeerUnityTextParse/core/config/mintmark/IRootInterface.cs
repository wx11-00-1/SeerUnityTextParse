using System;

namespace core.config.mintmark
{
	// Token: 0x02001FC5 RID: 8133
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E00 RID: 7680
		// (get) Token: 0x0600F52C RID: 62764 RVA: 0x003FA90C File Offset: 0x003F8B0C
		public override string fileName
		{
			get
			{
				return "mintmark";
			}
		}

		// Token: 0x17001E01 RID: 7681
		// (get) Token: 0x0600F52D RID: 62765 RVA: 0x003FA913 File Offset: 0x003F8B13
		// (set) Token: 0x0600F52E RID: 62766 RVA: 0x003FA91B File Offset: 0x003F8B1B
		public IMintMarks MintMarks { get; set; }

		// Token: 0x0600F52F RID: 62767 RVA: 0x003FA924 File Offset: 0x003F8B24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.MintMarks = new IMintMarks();
				this.MintMarks.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F530 RID: 62768 RVA: 0x003FA948 File Offset: 0x003F8B48
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
