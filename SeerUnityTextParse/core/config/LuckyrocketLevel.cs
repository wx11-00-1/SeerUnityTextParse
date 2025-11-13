using System;

namespace core.config
{
	// Token: 0x02001D89 RID: 7561
	public class LuckyrocketLevel : XlsConfigBase<LuckyrocketLevel, ILuckyrocketLevelInfo>
	{
		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x0600DDC6 RID: 56774 RVA: 0x003D5E47 File Offset: 0x003D4047
		public override string fileName
		{
			get
			{
				return "luckyrocketLevel";
			}
		}

		// Token: 0x0600DDC7 RID: 56775 RVA: 0x003D5E50 File Offset: 0x003D4050
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILuckyrocketLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILuckyrocketLevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DDC8 RID: 56776 RVA: 0x003D5EA4 File Offset: 0x003D40A4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
