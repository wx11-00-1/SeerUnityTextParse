using System;

namespace core.config
{
	// Token: 0x02001C99 RID: 7321
	public class AdAstraGalaxyTemp : XlsConfigBase<AdAstraGalaxyTemp, IAdAstraGalaxyTempInfo>
	{
		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x0600D3F6 RID: 54262 RVA: 0x003C9F34 File Offset: 0x003C8134
		public override string fileName
		{
			get
			{
				return "AdAstraGalaxy_temp";
			}
		}

		// Token: 0x0600D3F7 RID: 54263 RVA: 0x003C9F3C File Offset: 0x003C813C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAdAstraGalaxyTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAdAstraGalaxyTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D3F8 RID: 54264 RVA: 0x003C9F90 File Offset: 0x003C8190
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
