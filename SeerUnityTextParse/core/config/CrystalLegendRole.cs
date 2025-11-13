using System;

namespace core.config
{
	// Token: 0x02001D19 RID: 7449
	public class CrystalLegendRole : XlsConfigBase<CrystalLegendRole, ICrystalLegendRoleInfo>
	{
		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x0600D980 RID: 55680 RVA: 0x003D096A File Offset: 0x003CEB6A
		public override string fileName
		{
			get
			{
				return "crystalLegendRole";
			}
		}

		// Token: 0x0600D981 RID: 55681 RVA: 0x003D0974 File Offset: 0x003CEB74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendRoleInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendRoleInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D982 RID: 55682 RVA: 0x003D09C8 File Offset: 0x003CEBC8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
