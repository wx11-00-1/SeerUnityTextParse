using System;

namespace core.config
{
	// Token: 0x02001CE1 RID: 7393
	public class Buff : XlsConfigBase<Buff, IBuffInfo>
	{
		// Token: 0x17001303 RID: 4867
		// (get) Token: 0x0600D6A4 RID: 54948 RVA: 0x003CD2F9 File Offset: 0x003CB4F9
		public override string fileName
		{
			get
			{
				return "buff";
			}
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x003CD300 File Offset: 0x003CB500
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBuffInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBuffInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D6A6 RID: 54950 RVA: 0x003CD354 File Offset: 0x003CB554
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
