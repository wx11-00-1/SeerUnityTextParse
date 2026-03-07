using System;

namespace core.config
{
	// Token: 0x02001EF4 RID: 7924
	public class BagTowerEquipEffect : XlsConfigBase<BagTowerEquipEffect, IBagTowerEquipEffectInfo>
	{
		// Token: 0x1700133E RID: 4926
		// (get) Token: 0x0600EA50 RID: 59984 RVA: 0x0042BC7B File Offset: 0x00429E7B
		public override string fileName
		{
			get
			{
				return "bagTower_EquipEffect";
			}
		}

		// Token: 0x0600EA51 RID: 59985 RVA: 0x0042BC84 File Offset: 0x00429E84
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBagTowerEquipEffectInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBagTowerEquipEffectInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EA52 RID: 59986 RVA: 0x0042BCD8 File Offset: 0x00429ED8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
