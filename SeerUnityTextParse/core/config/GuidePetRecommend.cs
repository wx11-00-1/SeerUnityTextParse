using System;

namespace core.config
{
	// Token: 0x02001D61 RID: 7521
	public class GuidePetRecommend : XlsConfigBase<GuidePetRecommend, IGuidePetRecommendInfo>
	{
		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x0600DC3C RID: 56380 RVA: 0x003D402F File Offset: 0x003D222F
		public override string fileName
		{
			get
			{
				return "guidePetRecommend";
			}
		}

		// Token: 0x0600DC3D RID: 56381 RVA: 0x003D4038 File Offset: 0x003D2238
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IGuidePetRecommendInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IGuidePetRecommendInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DC3E RID: 56382 RVA: 0x003D408C File Offset: 0x003D228C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
