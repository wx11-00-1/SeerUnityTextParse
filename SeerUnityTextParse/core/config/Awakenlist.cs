using System;

namespace core.config
{
	// Token: 0x02001CAF RID: 7343
	public class Awakenlist : XlsConfigBase<Awakenlist, IAwakenlistInfo>
	{
		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x0600D4CA RID: 54474 RVA: 0x003CAF5B File Offset: 0x003C915B
		public override string fileName
		{
			get
			{
				return "awakenlist";
			}
		}

		// Token: 0x0600D4CB RID: 54475 RVA: 0x003CAF64 File Offset: 0x003C9164
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAwakenlistInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAwakenlistInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D4CC RID: 54476 RVA: 0x003CAFB8 File Offset: 0x003C91B8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
