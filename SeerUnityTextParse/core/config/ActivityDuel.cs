using System;

namespace core.config
{
	// Token: 0x0200275A RID: 10074
	public class ActivityDuel : XlsConfigBase<ActivityDuel, IActivityDuelInfo>
	{
		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x06013E94 RID: 81556 RVA: 0x005A3877 File Offset: 0x005A1A77
		public override string fileName
		{
			get
			{
				return "ActivityDuel";
			}
		}

		// Token: 0x06013E95 RID: 81557 RVA: 0x005A3880 File Offset: 0x005A1A80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IActivityDuelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IActivityDuelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013E96 RID: 81558 RVA: 0x005A38D4 File Offset: 0x005A1AD4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
