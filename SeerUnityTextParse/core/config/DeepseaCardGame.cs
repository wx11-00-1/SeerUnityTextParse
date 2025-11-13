using System;

namespace core.config
{
	// Token: 0x02001D25 RID: 7461
	public class DeepseaCardGame : XlsConfigBase<DeepseaCardGame, IDeepseaCardGameInfo>
	{
		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x0600D9EA RID: 55786 RVA: 0x003D1163 File Offset: 0x003CF363
		public override string fileName
		{
			get
			{
				return "deepseaCardGame";
			}
		}

		// Token: 0x0600D9EB RID: 55787 RVA: 0x003D116C File Offset: 0x003CF36C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDeepseaCardGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDeepseaCardGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D9EC RID: 55788 RVA: 0x003D11C0 File Offset: 0x003CF3C0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
