using System;

namespace core.config
{
	// Token: 0x020022E8 RID: 8936
	public class Petclassfix : XlsConfigBase<Petclassfix, IPetclassfixInfo>
	{
		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06010FAE RID: 69550 RVA: 0x004941C5 File Offset: 0x004923C5
		public override string fileName
		{
			get
			{
				return "petclassfix";
			}
		}

		// Token: 0x06010FAF RID: 69551 RVA: 0x004941CC File Offset: 0x004923CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPetclassfixInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPetclassfixInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06010FB0 RID: 69552 RVA: 0x00494220 File Offset: 0x00492420
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
