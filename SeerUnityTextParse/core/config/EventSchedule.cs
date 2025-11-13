using System;

namespace core.config
{
	// Token: 0x02001D3F RID: 7487
	public class EventSchedule : XlsConfigBase<EventSchedule, IEventScheduleInfo>
	{
		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x0600DAD0 RID: 56016 RVA: 0x003D22E5 File Offset: 0x003D04E5
		public override string fileName
		{
			get
			{
				return "eventSchedule";
			}
		}

		// Token: 0x0600DAD1 RID: 56017 RVA: 0x003D22EC File Offset: 0x003D04EC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IEventScheduleInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IEventScheduleInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DAD2 RID: 56018 RVA: 0x003D2340 File Offset: 0x003D0540
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
