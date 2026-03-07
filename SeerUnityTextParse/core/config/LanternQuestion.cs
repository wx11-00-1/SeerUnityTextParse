using System;

namespace core.config
{
	// Token: 0x02002000 RID: 8192
	public class LanternQuestion : XlsConfigBase<LanternQuestion, ILanternQuestionInfo>
	{
		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x0600F5EA RID: 62954 RVA: 0x00439B3E File Offset: 0x00437D3E
		public override string fileName
		{
			get
			{
				return "lanternQuestion";
			}
		}

		// Token: 0x0600F5EB RID: 62955 RVA: 0x00439B48 File Offset: 0x00437D48
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILanternQuestionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILanternQuestionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F5EC RID: 62956 RVA: 0x00439B9C File Offset: 0x00437D9C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
