using System;

namespace core.config
{
	// Token: 0x02001D13 RID: 7443
	public class CrystalLegendMap : XlsConfigBase<CrystalLegendMap, ICrystalLegendMapInfo>
	{
		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x0600D94A RID: 55626 RVA: 0x003D0567 File Offset: 0x003CE767
		public override string fileName
		{
			get
			{
				return "crystalLegendMap";
			}
		}

		// Token: 0x0600D94B RID: 55627 RVA: 0x003D0570 File Offset: 0x003CE770
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendMapInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendMapInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D94C RID: 55628 RVA: 0x003D05C4 File Offset: 0x003CE7C4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
