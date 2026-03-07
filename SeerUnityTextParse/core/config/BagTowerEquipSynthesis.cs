using System;

namespace core.config
{
	// Token: 0x02001EF6 RID: 7926
	public class BagTowerEquipSynthesis : XlsConfigBase<BagTowerEquipSynthesis, IBagTowerEquipSynthesisInfo>
	{
		// Token: 0x1700134E RID: 4942
		// (get) Token: 0x0600EA74 RID: 60020 RVA: 0x0042BF09 File Offset: 0x0042A109
		public override string fileName
		{
			get
			{
				return "bagTower_EquipSynthesis";
			}
		}

		// Token: 0x0600EA75 RID: 60021 RVA: 0x0042BF10 File Offset: 0x0042A110
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBagTowerEquipSynthesisInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBagTowerEquipSynthesisInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EA76 RID: 60022 RVA: 0x0042BF64 File Offset: 0x0042A164
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
