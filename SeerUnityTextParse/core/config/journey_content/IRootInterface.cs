using System;

namespace core.config.journey_content
{
	// Token: 0x02002587 RID: 9607
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002648 RID: 9800
		// (get) Token: 0x06012AFB RID: 76539 RVA: 0x004BE532 File Offset: 0x004BC732
		public override string fileName
		{
			get
			{
				return "journey_content";
			}
		}

		// Token: 0x17002649 RID: 9801
		// (get) Token: 0x06012AFC RID: 76540 RVA: 0x004BE539 File Offset: 0x004BC739
		// (set) Token: 0x06012AFD RID: 76541 RVA: 0x004BE541 File Offset: 0x004BC741
		public IRoot root { get; set; }

		// Token: 0x06012AFE RID: 76542 RVA: 0x004BE54A File Offset: 0x004BC74A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x06012AFF RID: 76543 RVA: 0x004BE570 File Offset: 0x004BC770
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
