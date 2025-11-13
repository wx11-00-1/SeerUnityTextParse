using System;

namespace core.config
{
	// Token: 0x02001D15 RID: 7445
	public class CrystalLegendMonster : XlsConfigBase<CrystalLegendMonster, ICrystalLegendMonsterInfo>
	{
		// Token: 0x1700142F RID: 5167
		// (get) Token: 0x0600D964 RID: 55652 RVA: 0x003D0758 File Offset: 0x003CE958
		public override string fileName
		{
			get
			{
				return "crystalLegendMonster";
			}
		}

		// Token: 0x0600D965 RID: 55653 RVA: 0x003D0760 File Offset: 0x003CE960
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendMonsterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendMonsterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D966 RID: 55654 RVA: 0x003D07B4 File Offset: 0x003CE9B4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
