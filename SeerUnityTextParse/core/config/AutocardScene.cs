using System;

namespace core.config
{
	// Token: 0x0200244E RID: 9294
	public class AutocardScene : XlsConfigBase<AutocardScene, IAutocardSceneInfo>
	{
		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x0601199A RID: 72090 RVA: 0x0050218C File Offset: 0x0050038C
		public override string fileName
		{
			get
			{
				return "autocardScene";
			}
		}

		// Token: 0x0601199B RID: 72091 RVA: 0x00502194 File Offset: 0x00500394
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardSceneInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardSceneInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601199C RID: 72092 RVA: 0x005021E8 File Offset: 0x005003E8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
