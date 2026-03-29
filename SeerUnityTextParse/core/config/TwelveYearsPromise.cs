using System;

namespace core.config
{
	// Token: 0x020023F2 RID: 9202
	public class TwelveYearsPromise : XlsConfigBase<TwelveYearsPromise, ITwelveYearsPromiseInfo>
	{
		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x06011B6C RID: 72556 RVA: 0x004A286E File Offset: 0x004A0A6E
		public override string fileName
		{
			get
			{
				return "twelveYearsPromise";
			}
		}

		// Token: 0x06011B6D RID: 72557 RVA: 0x004A2878 File Offset: 0x004A0A78
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITwelveYearsPromiseInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITwelveYearsPromiseInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011B6E RID: 72558 RVA: 0x004A28CC File Offset: 0x004A0ACC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
