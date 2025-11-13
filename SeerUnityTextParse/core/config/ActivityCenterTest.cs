using System;

namespace core.config
{
	// Token: 0x02001C8B RID: 7307
	public class ActivityCenterTest : XlsConfigBase<ActivityCenterTest, IActivityCenterTestInfo>
	{
		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x0600D33A RID: 54074 RVA: 0x003C91FF File Offset: 0x003C73FF
		public override string fileName
		{
			get
			{
				return "ActivityCenter_test";
			}
		}

		// Token: 0x0600D33B RID: 54075 RVA: 0x003C9208 File Offset: 0x003C7408
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IActivityCenterTestInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IActivityCenterTestInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D33C RID: 54076 RVA: 0x003C9268 File Offset: 0x003C7468
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400E520 RID: 58656
		private bool b;
	}
}
