using System;

namespace core.config.activityTimeControl
{
	// Token: 0x02002083 RID: 8323
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002141 RID: 8513
		// (get) Token: 0x0600FE1B RID: 65051 RVA: 0x00403ED4 File Offset: 0x004020D4
		public override string fileName
		{
			get
			{
				return "activityTimeControl";
			}
		}

		// Token: 0x17002142 RID: 8514
		// (get) Token: 0x0600FE1C RID: 65052 RVA: 0x00403EDB File Offset: 0x004020DB
		// (set) Token: 0x0600FE1D RID: 65053 RVA: 0x00403EE3 File Offset: 0x004020E3
		public IConfig config { get; set; }

		// Token: 0x0600FE1E RID: 65054 RVA: 0x00403EEC File Offset: 0x004020EC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.config = new IConfig();
				this.config.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FE1F RID: 65055 RVA: 0x00403F10 File Offset: 0x00402110
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
