using System;

namespace core.config
{
	// Token: 0x02001D5D RID: 7517
	public class GlobalStr : XlsConfigBase<GlobalStr, IGlobalStrInfo>
	{
		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x0600DC22 RID: 56354 RVA: 0x003D3E27 File Offset: 0x003D2027
		public override string fileName
		{
			get
			{
				return "globalStr";
			}
		}

		// Token: 0x0600DC23 RID: 56355 RVA: 0x003D3E30 File Offset: 0x003D2030
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IGlobalStrInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IGlobalStrInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DC24 RID: 56356 RVA: 0x003D3E84 File Offset: 0x003D2084
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
