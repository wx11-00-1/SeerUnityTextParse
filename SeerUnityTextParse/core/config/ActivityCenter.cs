using System;

namespace core.config
{
	// Token: 0x02001C87 RID: 7303
	public class ActivityCenter : XlsConfigBase<ActivityCenter, IActivityCenterInfo>
	{
		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x0600D2F2 RID: 54002 RVA: 0x003C8D0F File Offset: 0x003C6F0F
		public override string fileName
		{
			get
			{
				return "ActivityCenter";
			}
		}

		// Token: 0x0600D2F3 RID: 54003 RVA: 0x003C8D18 File Offset: 0x003C6F18
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IActivityCenterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IActivityCenterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D2F4 RID: 54004 RVA: 0x003C8D6C File Offset: 0x003C6F6C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
