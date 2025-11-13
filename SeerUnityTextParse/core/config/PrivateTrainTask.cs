using System;

namespace core.config
{
	// Token: 0x02001DCD RID: 7629
	public class PrivateTrainTask : XlsConfigBase<PrivateTrainTask, IPrivateTrainTaskInfo>
	{
		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x0600E0A2 RID: 57506 RVA: 0x003D97EB File Offset: 0x003D79EB
		public override string fileName
		{
			get
			{
				return "privateTrainTask";
			}
		}

		// Token: 0x0600E0A3 RID: 57507 RVA: 0x003D97F4 File Offset: 0x003D79F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPrivateTrainTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPrivateTrainTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E0A4 RID: 57508 RVA: 0x003D9848 File Offset: 0x003D7A48
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
