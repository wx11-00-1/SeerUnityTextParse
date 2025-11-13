using System;

namespace core.config
{
	// Token: 0x02001D75 RID: 7541
	public class LightAndAarkDeities : XlsConfigBase<LightAndAarkDeities, ILightAndAarkDeitiesInfo>
	{
		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x0600DCF4 RID: 56564 RVA: 0x003D4F4F File Offset: 0x003D314F
		public override string fileName
		{
			get
			{
				return "LightAndAarkDeities";
			}
		}

		// Token: 0x0600DCF5 RID: 56565 RVA: 0x003D4F58 File Offset: 0x003D3158
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILightAndAarkDeitiesInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILightAndAarkDeitiesInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DCF6 RID: 56566 RVA: 0x003D4FAC File Offset: 0x003D31AC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
