using System;

namespace core.config
{
	// Token: 0x02001F02 RID: 7938
	public class BagTowerStageWave : XlsConfigBase<BagTowerStageWave, IBagTowerStageWaveInfo>
	{
		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x0600EB14 RID: 60180 RVA: 0x0042CA89 File Offset: 0x0042AC89
		public override string fileName
		{
			get
			{
				return "bagTower_StageWave";
			}
		}

		// Token: 0x0600EB15 RID: 60181 RVA: 0x0042CA90 File Offset: 0x0042AC90
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBagTowerStageWaveInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBagTowerStageWaveInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EB16 RID: 60182 RVA: 0x0042CAE4 File Offset: 0x0042ACE4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
