using System;

namespace core.config
{
	// Token: 0x02001D77 RID: 7543
	public class LightAndAarkPrizeDraw : XlsConfigBase<LightAndAarkPrizeDraw, ILightAndAarkPrizeDrawInfo>
	{
		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x0600DD0E RID: 56590 RVA: 0x003D511D File Offset: 0x003D331D
		public override string fileName
		{
			get
			{
				return "LightAndAarkPrizeDraw";
			}
		}

		// Token: 0x0600DD0F RID: 56591 RVA: 0x003D5124 File Offset: 0x003D3324
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILightAndAarkPrizeDrawInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILightAndAarkPrizeDrawInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DD10 RID: 56592 RVA: 0x003D5178 File Offset: 0x003D3378
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
