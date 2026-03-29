using System;

namespace core.config
{
	// Token: 0x02002286 RID: 8838
	public class LearningpowerTower : XlsConfigBase<LearningpowerTower, ILearningpowerTowerInfo>
	{
		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06010B56 RID: 68438 RVA: 0x0048EB0E File Offset: 0x0048CD0E
		public override string fileName
		{
			get
			{
				return "learningpower_tower";
			}
		}

		// Token: 0x06010B57 RID: 68439 RVA: 0x0048EB18 File Offset: 0x0048CD18
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILearningpowerTowerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILearningpowerTowerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06010B58 RID: 68440 RVA: 0x0048EB6C File Offset: 0x0048CD6C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
