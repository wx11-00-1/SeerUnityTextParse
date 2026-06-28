using System;

namespace core.config
{
	// Token: 0x0200258C RID: 9612
	public class AutocardSession : XlsConfigBase<AutocardSession, IAutocardSessionInfo>
	{
		// Token: 0x17001845 RID: 6213
		// (get) Token: 0x06012A8D RID: 76429 RVA: 0x005479BD File Offset: 0x00545BBD
		public override string fileName
		{
			get
			{
				return "autocardSession";
			}
		}

		// Token: 0x06012A8E RID: 76430 RVA: 0x005479C4 File Offset: 0x00545BC4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardSessionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardSessionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06012A8F RID: 76431 RVA: 0x00547A18 File Offset: 0x00545C18
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
