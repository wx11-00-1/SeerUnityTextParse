using System;

namespace core.config.AdventureStory
{
	// Token: 0x02002632 RID: 9778
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x060133B5 RID: 78773 RVA: 0x004C7580 File Offset: 0x004C5780
		public override string fileName
		{
			get
			{
				return "AdventureStory";
			}
		}

		// Token: 0x17002985 RID: 10629
		// (get) Token: 0x060133B6 RID: 78774 RVA: 0x004C7587 File Offset: 0x004C5787
		// (set) Token: 0x060133B7 RID: 78775 RVA: 0x004C758F File Offset: 0x004C578F
		public IAdventureStory AdventureStory { get; set; }

		// Token: 0x060133B8 RID: 78776 RVA: 0x004C7598 File Offset: 0x004C5798
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.AdventureStory = new IAdventureStory();
				this.AdventureStory.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x060133B9 RID: 78777 RVA: 0x004C75BC File Offset: 0x004C57BC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
