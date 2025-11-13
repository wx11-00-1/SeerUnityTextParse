using System;

namespace core.config
{
	// Token: 0x02001CCF RID: 7375
	public class BraveTowerReverseDefenseChallenger : XlsConfigBase<BraveTowerReverseDefenseChallenger, IBraveTowerReverseDefenseChallengerInfo>
	{
		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x0600D61A RID: 54810 RVA: 0x003CC7C7 File Offset: 0x003CA9C7
		public override string fileName
		{
			get
			{
				return "BraveTowerReverseDefense_challenger";
			}
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x003CC7D0 File Offset: 0x003CA9D0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBraveTowerReverseDefenseChallengerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBraveTowerReverseDefenseChallengerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D61C RID: 54812 RVA: 0x003CC824 File Offset: 0x003CAA24
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
