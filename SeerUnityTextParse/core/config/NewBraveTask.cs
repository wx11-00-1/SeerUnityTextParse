using System;

namespace core.config
{
	// Token: 0x02001DA3 RID: 7587
	public class NewBraveTask : XlsConfigBase<NewBraveTask, INewBraveTaskInfo>
	{
		// Token: 0x17001649 RID: 5705
		// (get) Token: 0x0600DEB4 RID: 57012 RVA: 0x003D72A2 File Offset: 0x003D54A2
		public override string fileName
		{
			get
			{
				return "newBraveTask";
			}
		}

		// Token: 0x0600DEB5 RID: 57013 RVA: 0x003D72AC File Offset: 0x003D54AC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INewBraveTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INewBraveTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DEB6 RID: 57014 RVA: 0x003D7300 File Offset: 0x003D5500
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
