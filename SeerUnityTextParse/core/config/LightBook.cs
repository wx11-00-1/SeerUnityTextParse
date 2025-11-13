using System;

namespace core.config
{
	// Token: 0x02001D79 RID: 7545
	public class LightBook : XlsConfigBase<LightBook, ILightBookInfo>
	{
		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x0600DD1C RID: 56604 RVA: 0x003D521A File Offset: 0x003D341A
		public override string fileName
		{
			get
			{
				return "light_book";
			}
		}

		// Token: 0x0600DD1D RID: 56605 RVA: 0x003D5224 File Offset: 0x003D3424
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILightBookInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILightBookInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DD1E RID: 56606 RVA: 0x003D5278 File Offset: 0x003D3478
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
