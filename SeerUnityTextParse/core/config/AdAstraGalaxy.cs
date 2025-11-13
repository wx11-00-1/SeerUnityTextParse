using System;

namespace core.config
{
	// Token: 0x02001C95 RID: 7317
	public class AdAstraGalaxy : XlsConfigBase<AdAstraGalaxy, IAdAstraGalaxyInfo>
	{
		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x0600D3BA RID: 54202 RVA: 0x003C9AFD File Offset: 0x003C7CFD
		public override string fileName
		{
			get
			{
				return "AdAstraGalaxy";
			}
		}

		// Token: 0x0600D3BB RID: 54203 RVA: 0x003C9B04 File Offset: 0x003C7D04
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAdAstraGalaxyInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAdAstraGalaxyInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D3BC RID: 54204 RVA: 0x003C9B58 File Offset: 0x003C7D58
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
