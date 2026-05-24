using System;

namespace core.config
{
	// Token: 0x02002430 RID: 9264
	public class AurumEndgameStageConfig : XlsConfigBase<AurumEndgameStageConfig, IAurumEndgameStageConfigInfo>
	{
		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06011864 RID: 71780 RVA: 0x005009E4 File Offset: 0x004FEBE4
		public override string fileName
		{
			get
			{
				return "aurumEndgameStageConfig";
			}
		}

		// Token: 0x06011865 RID: 71781 RVA: 0x005009EC File Offset: 0x004FEBEC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAurumEndgameStageConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAurumEndgameStageConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011866 RID: 71782 RVA: 0x00500A40 File Offset: 0x004FEC40
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
