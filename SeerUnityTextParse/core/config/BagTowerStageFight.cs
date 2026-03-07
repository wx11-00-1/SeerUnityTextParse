using System;

namespace core.config
{
	// Token: 0x02001F00 RID: 7936
	public class BagTowerStageFight : XlsConfigBase<BagTowerStageFight, IBagTowerStageFightInfo>
	{
		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x0600EAFA RID: 60154 RVA: 0x0042C875 File Offset: 0x0042AA75
		public override string fileName
		{
			get
			{
				return "bagTower_StageFight";
			}
		}

		// Token: 0x0600EAFB RID: 60155 RVA: 0x0042C87C File Offset: 0x0042AA7C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBagTowerStageFightInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBagTowerStageFightInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EAFC RID: 60156 RVA: 0x0042C8D0 File Offset: 0x0042AAD0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
