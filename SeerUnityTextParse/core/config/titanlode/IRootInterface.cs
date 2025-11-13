using System;

namespace core.config.titanlode
{
	// Token: 0x02001F0C RID: 7948
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x0600EDF6 RID: 60918 RVA: 0x003F1DF0 File Offset: 0x003EFFF0
		public override string fileName
		{
			get
			{
				return "titanlode";
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x0600EDF7 RID: 60919 RVA: 0x003F1DF7 File Offset: 0x003EFFF7
		// (set) Token: 0x0600EDF8 RID: 60920 RVA: 0x003F1DFF File Offset: 0x003EFFFF
		public IRoot root { get; set; }

		// Token: 0x0600EDF9 RID: 60921 RVA: 0x003F1E08 File Offset: 0x003F0008
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EDFA RID: 60922 RVA: 0x003F1E38 File Offset: 0x003F0038
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400F07C RID: 61564
		private bool b;
	}
}
