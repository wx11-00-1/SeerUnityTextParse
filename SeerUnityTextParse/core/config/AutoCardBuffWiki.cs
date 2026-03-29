using System;

namespace core.config
{
	// Token: 0x02002128 RID: 8488
	public class AutoCardBuffWiki : XlsConfigBase<AutoCardBuffWiki, IAutoCardBuffWikiInfo>
	{
		// Token: 0x170014A0 RID: 5280
		// (get) Token: 0x0600FC10 RID: 64528 RVA: 0x0047C6E4 File Offset: 0x0047A8E4
		public override string fileName
		{
			get
			{
				return "autoCardBuffWiki";
			}
		}

		// Token: 0x0600FC11 RID: 64529 RVA: 0x0047C6EC File Offset: 0x0047A8EC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutoCardBuffWikiInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutoCardBuffWikiInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FC12 RID: 64530 RVA: 0x0047C740 File Offset: 0x0047A940
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
