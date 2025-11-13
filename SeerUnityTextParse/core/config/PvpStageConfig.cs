using System;

namespace core.config
{
	// Token: 0x02001DE7 RID: 7655
	public class PvpStageConfig : XlsConfigBase<PvpStageConfig, IPvpStageConfigInfo>
	{
		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x0600E1C4 RID: 57796 RVA: 0x003DAE2D File Offset: 0x003D902D
		public override string fileName
		{
			get
			{
				return "pvp_StageConfig";
			}
		}

		// Token: 0x0600E1C5 RID: 57797 RVA: 0x003DAE34 File Offset: 0x003D9034
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpStageConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpStageConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E1C6 RID: 57798 RVA: 0x003DAE88 File Offset: 0x003D9088
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
