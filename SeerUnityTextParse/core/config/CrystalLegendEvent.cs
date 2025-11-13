using System;

namespace core.config
{
	// Token: 0x02001D11 RID: 7441
	public class CrystalLegendEvent : XlsConfigBase<CrystalLegendEvent, ICrystalLegendEventInfo>
	{
		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x0600D936 RID: 55606 RVA: 0x003D03E1 File Offset: 0x003CE5E1
		public override string fileName
		{
			get
			{
				return "crystalLegendEvent";
			}
		}

		// Token: 0x0600D937 RID: 55607 RVA: 0x003D03E8 File Offset: 0x003CE5E8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendEventInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendEventInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D938 RID: 55608 RVA: 0x003D043C File Offset: 0x003CE63C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
