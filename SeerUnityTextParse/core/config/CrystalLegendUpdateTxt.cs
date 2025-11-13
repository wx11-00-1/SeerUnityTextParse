using System;

namespace core.config
{
	// Token: 0x02001D1F RID: 7455
	public class CrystalLegendUpdateTxt : XlsConfigBase<CrystalLegendUpdateTxt, ICrystalLegendUpdateTxtInfo>
	{
		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x0600D9B2 RID: 55730 RVA: 0x003D0D3D File Offset: 0x003CEF3D
		public override string fileName
		{
			get
			{
				return "crystalLegendUpdateTxt";
			}
		}

		// Token: 0x0600D9B3 RID: 55731 RVA: 0x003D0D44 File Offset: 0x003CEF44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendUpdateTxtInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendUpdateTxtInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D9B4 RID: 55732 RVA: 0x003D0D98 File Offset: 0x003CEF98
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
