using System;

namespace core.config
{
	// Token: 0x02001D9F RID: 7583
	public class NewBraveChallenge : XlsConfigBase<NewBraveChallenge, INewBraveChallengeInfo>
	{
		// Token: 0x1700163F RID: 5695
		// (get) Token: 0x0600DE98 RID: 56984 RVA: 0x003D7023 File Offset: 0x003D5223
		public override string fileName
		{
			get
			{
				return "newBraveChallenge";
			}
		}

		// Token: 0x0600DE99 RID: 56985 RVA: 0x003D702C File Offset: 0x003D522C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INewBraveChallengeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INewBraveChallengeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DE9A RID: 56986 RVA: 0x003D7080 File Offset: 0x003D5280
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
