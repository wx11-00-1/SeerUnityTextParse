using System;

namespace core.config
{
	// Token: 0x02001D21 RID: 7457
	public class Dailytask : XlsConfigBase<Dailytask, IDailytaskInfo>
	{
		// Token: 0x17001451 RID: 5201
		// (get) Token: 0x0600D9C0 RID: 55744 RVA: 0x003D0E53 File Offset: 0x003CF053
		public override string fileName
		{
			get
			{
				return "dailytask";
			}
		}

		// Token: 0x0600D9C1 RID: 55745 RVA: 0x003D0E5C File Offset: 0x003CF05C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDailytaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDailytaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D9C2 RID: 55746 RVA: 0x003D0EB0 File Offset: 0x003CF0B0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
