using System;

namespace core.config
{
	// Token: 0x02001C89 RID: 7305
	public class ActivityCenterBisaifu : XlsConfigBase<ActivityCenterBisaifu, IActivityCenterBisaifuInfo>
	{
		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x0600D316 RID: 54038 RVA: 0x003C8F87 File Offset: 0x003C7187
		public override string fileName
		{
			get
			{
				return "ActivityCenter_bisaifu";
			}
		}

		// Token: 0x0600D317 RID: 54039 RVA: 0x003C8F90 File Offset: 0x003C7190
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IActivityCenterBisaifuInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IActivityCenterBisaifuInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D318 RID: 54040 RVA: 0x003C8FE4 File Offset: 0x003C71E4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
