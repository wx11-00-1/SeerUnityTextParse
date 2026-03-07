using System;

namespace core.config
{
	// Token: 0x02001EF8 RID: 7928
	public class BagTowerEquipUpgrade : XlsConfigBase<BagTowerEquipUpgrade, IBagTowerEquipUpgradeInfo>
	{
		// Token: 0x1700135A RID: 4954
		// (get) Token: 0x0600EA90 RID: 60048 RVA: 0x0042C0F2 File Offset: 0x0042A2F2
		public override string fileName
		{
			get
			{
				return "bagTower_EquipUpgrade";
			}
		}

		// Token: 0x0600EA91 RID: 60049 RVA: 0x0042C0FC File Offset: 0x0042A2FC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBagTowerEquipUpgradeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBagTowerEquipUpgradeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EA92 RID: 60050 RVA: 0x0042C150 File Offset: 0x0042A350
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
