using System;

namespace core.config
{
	// Token: 0x02001C97 RID: 7319
	public class AdAstraGalaxyGuoqing : XlsConfigBase<AdAstraGalaxyGuoqing, IAdAstraGalaxyGuoqingInfo>
	{
		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x0600D3D8 RID: 54232 RVA: 0x003C9D18 File Offset: 0x003C7F18
		public override string fileName
		{
			get
			{
				return "AdAstraGalaxy_guoqing";
			}
		}

		// Token: 0x0600D3D9 RID: 54233 RVA: 0x003C9D20 File Offset: 0x003C7F20
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAdAstraGalaxyGuoqingInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAdAstraGalaxyGuoqingInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D3DA RID: 54234 RVA: 0x003C9D74 File Offset: 0x003C7F74
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
