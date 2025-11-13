using System;

namespace core.config
{
	// Token: 0x02001CAD RID: 7341
	public class Awakencondition : XlsConfigBase<Awakencondition, IAwakenconditionInfo>
	{
		// Token: 0x17001243 RID: 4675
		// (get) Token: 0x0600D4BC RID: 54460 RVA: 0x003CAE42 File Offset: 0x003C9042
		public override string fileName
		{
			get
			{
				return "awakencondition";
			}
		}

		// Token: 0x0600D4BD RID: 54461 RVA: 0x003CAE4C File Offset: 0x003C904C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAwakenconditionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAwakenconditionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D4BE RID: 54462 RVA: 0x003CAEA0 File Offset: 0x003C90A0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
