using System;

namespace core.config
{
	// Token: 0x02001D0F RID: 7439
	public class CrystalLegendDiceSurface : XlsConfigBase<CrystalLegendDiceSurface, ICrystalLegendDiceSurfaceInfo>
	{
		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x0600D924 RID: 55588 RVA: 0x003D028A File Offset: 0x003CE48A
		public override string fileName
		{
			get
			{
				return "crystalLegendDiceSurface";
			}
		}

		// Token: 0x0600D925 RID: 55589 RVA: 0x003D0294 File Offset: 0x003CE494
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ICrystalLegendDiceSurfaceInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ICrystalLegendDiceSurfaceInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D926 RID: 55590 RVA: 0x003D02E8 File Offset: 0x003CE4E8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
