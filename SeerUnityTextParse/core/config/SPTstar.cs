using System;

namespace core.config
{
	// Token: 0x02001E31 RID: 7729
	public class SPTstar : XlsConfigBase<SPTstar, ISPTstarInfo>
	{
		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x0600E4EA RID: 58602 RVA: 0x003DEF6E File Offset: 0x003DD16E
		public override string fileName
		{
			get
			{
				return "SPTstar";
			}
		}

		// Token: 0x0600E4EB RID: 58603 RVA: 0x003DEF78 File Offset: 0x003DD178
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISPTstarInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISPTstarInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E4EC RID: 58604 RVA: 0x003DEFCC File Offset: 0x003DD1CC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
