using System;

namespace core.config
{
	// Token: 0x02001D3B RID: 7483
	public class Effectag : XlsConfigBase<Effectag, IEffectagInfo>
	{
		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x0600DABC RID: 55996 RVA: 0x003D2155 File Offset: 0x003D0355
		public override string fileName
		{
			get
			{
				return "effectag";
			}
		}

		// Token: 0x0600DABD RID: 55997 RVA: 0x003D215C File Offset: 0x003D035C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IEffectagInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IEffectagInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DABE RID: 55998 RVA: 0x003D21B0 File Offset: 0x003D03B0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
