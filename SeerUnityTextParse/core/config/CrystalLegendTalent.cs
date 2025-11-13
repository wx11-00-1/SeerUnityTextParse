using System;

namespace core.config
{
	// Token: 0x02001D1D RID: 7453
	public class CrystalLegendTalent : XlsConfigBase<CrystalLegendTalent, ICrystalLegendTalentInfo>
	{
		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x0600D9A0 RID: 55712 RVA: 0x003D0BE8 File Offset: 0x003CEDE8
		public override string fileName
		{
			get
			{
				return "crystalLegendTalent";
			}
		}

		// Token: 0x0600D9A1 RID: 55713 RVA: 0x003D0BF0 File Offset: 0x003CEDF0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendTalentInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendTalentInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D9A2 RID: 55714 RVA: 0x003D0C44 File Offset: 0x003CEE44
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
