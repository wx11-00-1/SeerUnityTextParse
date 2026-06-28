using System;

namespace core.config
{
	// Token: 0x0200258E RID: 9614
	public class AutocardSessionStore : XlsConfigBase<AutocardSessionStore, IAutocardSessionStoreInfo>
	{
		// Token: 0x17001859 RID: 6233
		// (get) Token: 0x06012AB9 RID: 76473 RVA: 0x00547CDC File Offset: 0x00545EDC
		public override string fileName
		{
			get
			{
				return "autocardSessionStore";
			}
		}

		// Token: 0x06012ABA RID: 76474 RVA: 0x00547CE4 File Offset: 0x00545EE4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardSessionStoreInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardSessionStoreInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06012ABB RID: 76475 RVA: 0x00547D38 File Offset: 0x00545F38
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
