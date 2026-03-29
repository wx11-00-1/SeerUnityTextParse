using System;

namespace core.config
{
	// Token: 0x02002154 RID: 8532
	public class Awakentask : XlsConfigBase<Awakentask, IAwakentaskInfo>
	{
		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x0600FDD0 RID: 64976 RVA: 0x0047E7A0 File Offset: 0x0047C9A0
		public override string fileName
		{
			get
			{
				return "awakentask";
			}
		}

		// Token: 0x0600FDD1 RID: 64977 RVA: 0x0047E7A8 File Offset: 0x0047C9A8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAwakentaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAwakentaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FDD2 RID: 64978 RVA: 0x0047E7FC File Offset: 0x0047C9FC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
