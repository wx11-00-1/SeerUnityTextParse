using System;

namespace core.config
{
	// Token: 0x02001EFE RID: 7934
	public class BagTowerStage : XlsConfigBase<BagTowerStage, IBagTowerStageInfo>
	{
		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x0600EAE2 RID: 60130 RVA: 0x0042C6CC File Offset: 0x0042A8CC
		public override string fileName
		{
			get
			{
				return "bagTower_Stage";
			}
		}

		// Token: 0x0600EAE3 RID: 60131 RVA: 0x0042C6D4 File Offset: 0x0042A8D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBagTowerStageInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBagTowerStageInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EAE4 RID: 60132 RVA: 0x0042C728 File Offset: 0x0042A928
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
