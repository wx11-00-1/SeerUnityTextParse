using System;

namespace core.config
{
	// Token: 0x02001D17 RID: 7447
	public class CrystalLegendMonsterAction : XlsConfigBase<CrystalLegendMonsterAction, ICrystalLegendMonsterActionInfo>
	{
		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x0600D970 RID: 55664 RVA: 0x003D083F File Offset: 0x003CEA3F
		public override string fileName
		{
			get
			{
				return "crystalLegendMonsterAction";
			}
		}

		// Token: 0x0600D971 RID: 55665 RVA: 0x003D0848 File Offset: 0x003CEA48
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendMonsterActionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendMonsterActionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D972 RID: 55666 RVA: 0x003D089C File Offset: 0x003CEA9C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
