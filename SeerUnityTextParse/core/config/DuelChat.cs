using System;

namespace core.config
{
	// Token: 0x02002894 RID: 10388
	public class DuelChat : XlsConfigBase<DuelChat, IDuelChatInfo>
	{
		// Token: 0x17001D9E RID: 7582
		// (get) Token: 0x06014C40 RID: 85056 RVA: 0x005B3A7B File Offset: 0x005B1C7B
		public override string fileName
		{
			get
			{
				return "DuelChat";
			}
		}

		// Token: 0x06014C41 RID: 85057 RVA: 0x005B3A84 File Offset: 0x005B1C84
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDuelChatInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDuelChatInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014C42 RID: 85058 RVA: 0x005B3AD8 File Offset: 0x005B1CD8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
