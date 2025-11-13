using System;

namespace core.config.energyCollect
{
	// Token: 0x02002046 RID: 8262
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x0600FC51 RID: 64593 RVA: 0x00401C62 File Offset: 0x003FFE62
		public override string fileName
		{
			get
			{
				return "energyCollect";
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x0600FC52 RID: 64594 RVA: 0x00401C69 File Offset: 0x003FFE69
		// (set) Token: 0x0600FC53 RID: 64595 RVA: 0x00401C71 File Offset: 0x003FFE71
		public IRoot root { get; set; }

		// Token: 0x0600FC54 RID: 64596 RVA: 0x00401C7A File Offset: 0x003FFE7A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600FC55 RID: 64597 RVA: 0x00401CA0 File Offset: 0x003FFEA0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
