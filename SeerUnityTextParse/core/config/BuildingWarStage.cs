using System;

namespace core.config
{
	// Token: 0x02001CE5 RID: 7397
	public class BuildingWarStage : XlsConfigBase<BuildingWarStage, IBuildingWarStageInfo>
	{
		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x0600D6CE RID: 54990 RVA: 0x003CD6AB File Offset: 0x003CB8AB
		public override string fileName
		{
			get
			{
				return "buildingWar_stage";
			}
		}

		// Token: 0x0600D6CF RID: 54991 RVA: 0x003CD6B4 File Offset: 0x003CB8B4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBuildingWarStageInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBuildingWarStageInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D6D0 RID: 54992 RVA: 0x003CD708 File Offset: 0x003CB908
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
