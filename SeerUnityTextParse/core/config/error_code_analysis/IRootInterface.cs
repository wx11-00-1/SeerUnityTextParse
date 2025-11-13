using System;

namespace core.config.error_code_analysis
{
	// Token: 0x0200203F RID: 8255
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002085 RID: 8325
		// (get) Token: 0x0600FC1B RID: 64539 RVA: 0x00401882 File Offset: 0x003FFA82
		public override string fileName
		{
			get
			{
				return "error_code_analysis";
			}
		}

		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x0600FC1C RID: 64540 RVA: 0x00401889 File Offset: 0x003FFA89
		// (set) Token: 0x0600FC1D RID: 64541 RVA: 0x00401891 File Offset: 0x003FFA91
		public IRoot root { get; set; }

		// Token: 0x0600FC1E RID: 64542 RVA: 0x0040189A File Offset: 0x003FFA9A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FC1F RID: 64543 RVA: 0x004018CC File Offset: 0x003FFACC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400F5CC RID: 62924
		private bool b;
	}
}
