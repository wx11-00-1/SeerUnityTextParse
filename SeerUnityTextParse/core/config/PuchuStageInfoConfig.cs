using System;

namespace core.config
{
	// Token: 0x0200261E RID: 9758
	public class PuchuStageInfoConfig : XlsConfigBase<PuchuStageInfoConfig, IPuchuStageInfoConfigInfo>
	{
		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06012DCE RID: 77262 RVA: 0x0051A753 File Offset: 0x00518953
		public override string fileName
		{
			get
			{
				return "puchuStageInfoConfig";
			}
		}

		// Token: 0x06012DCF RID: 77263 RVA: 0x0051A75C File Offset: 0x0051895C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPuchuStageInfoConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPuchuStageInfoConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06012DD0 RID: 77264 RVA: 0x0051A7B0 File Offset: 0x005189B0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
