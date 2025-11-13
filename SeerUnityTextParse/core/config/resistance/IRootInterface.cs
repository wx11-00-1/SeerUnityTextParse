using System;

namespace core.config.resistance
{
	// Token: 0x02001F32 RID: 7986
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x0600EF8A RID: 61322 RVA: 0x003F3B73 File Offset: 0x003F1D73
		public override string fileName
		{
			get
			{
				return "resistance";
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x0600EF8B RID: 61323 RVA: 0x003F3B7A File Offset: 0x003F1D7A
		// (set) Token: 0x0600EF8C RID: 61324 RVA: 0x003F3B82 File Offset: 0x003F1D82
		public IRoot root { get; set; }

		// Token: 0x0600EF8D RID: 61325 RVA: 0x003F3B8B File Offset: 0x003F1D8B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EF8E RID: 61326 RVA: 0x003F3BB0 File Offset: 0x003F1DB0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
