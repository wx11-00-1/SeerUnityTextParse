using System;

namespace core.config
{
	// Token: 0x02001EFA RID: 7930
	public class BagTowerMonster : XlsConfigBase<BagTowerMonster, IBagTowerMonsterInfo>
	{
		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x0600EABE RID: 60094 RVA: 0x0042C416 File Offset: 0x0042A616
		public override string fileName
		{
			get
			{
				return "bagTower_Monster";
			}
		}

		// Token: 0x0600EABF RID: 60095 RVA: 0x0042C420 File Offset: 0x0042A620
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBagTowerMonsterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBagTowerMonsterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EAC0 RID: 60096 RVA: 0x0042C474 File Offset: 0x0042A674
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
