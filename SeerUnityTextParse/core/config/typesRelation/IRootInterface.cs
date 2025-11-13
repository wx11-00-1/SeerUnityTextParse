using System;

namespace core.config.typesRelation
{
	// Token: 0x02001F07 RID: 7943
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x0600EDD0 RID: 60880 RVA: 0x003F1AAE File Offset: 0x003EFCAE
		public override string fileName
		{
			get
			{
				return "typesRelation";
			}
		}

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x0600EDD1 RID: 60881 RVA: 0x003F1AB5 File Offset: 0x003EFCB5
		// (set) Token: 0x0600EDD2 RID: 60882 RVA: 0x003F1ABD File Offset: 0x003EFCBD
		public IRoot Root { get; set; }

		// Token: 0x0600EDD3 RID: 60883 RVA: 0x003F1AC6 File Offset: 0x003EFCC6
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Root = new IRoot();
				this.Root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EDD4 RID: 60884 RVA: 0x003F1AEC File Offset: 0x003EFCEC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
