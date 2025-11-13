using System;

namespace core.config
{
	// Token: 0x02001CE3 RID: 7395
	public class BuildingWarBuilding : XlsConfigBase<BuildingWarBuilding, IBuildingWarBuildingInfo>
	{
		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x0600D6B6 RID: 54966 RVA: 0x003CD47F File Offset: 0x003CB67F
		public override string fileName
		{
			get
			{
				return "buildingWar_building";
			}
		}

		// Token: 0x0600D6B7 RID: 54967 RVA: 0x003CD488 File Offset: 0x003CB688
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBuildingWarBuildingInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBuildingWarBuildingInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D6B8 RID: 54968 RVA: 0x003CD4DC File Offset: 0x003CB6DC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
