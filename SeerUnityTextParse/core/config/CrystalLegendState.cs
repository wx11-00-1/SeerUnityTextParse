using System;

namespace core.config
{
	// Token: 0x02001D1B RID: 7451
	public class CrystalLegendState : XlsConfigBase<CrystalLegendState, ICrystalLegendStateInfo>
	{
		// Token: 0x1700143E RID: 5182
		// (get) Token: 0x0600D98E RID: 55694 RVA: 0x003D0A8A File Offset: 0x003CEC8A
		public override string fileName
		{
			get
			{
				return "crystalLegendState";
			}
		}

		// Token: 0x0600D98F RID: 55695 RVA: 0x003D0A94 File Offset: 0x003CEC94
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendStateInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendStateInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D990 RID: 55696 RVA: 0x003D0AE8 File Offset: 0x003CECE8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
