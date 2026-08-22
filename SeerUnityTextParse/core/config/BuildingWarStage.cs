namespace core.config
{
	public class BuildingWarStage : XlsConfigBase<BuildingWarStage, IBuildingWarStageInfo>
	{
		public override string fileName
		{
			get
			{
				return "buildingWar_stage";
			}
		}

		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				data = new IBuildingWarStageInfo[num];
				for (int i = 0; i < num; i++)
				{
					data[i] = new IBuildingWarStageInfo();
					data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		public override void Parse(byte[] bytes)
		{
			int byteIndex = 0;
			Parse(bytes, ref byteIndex);
		}
	}
}
