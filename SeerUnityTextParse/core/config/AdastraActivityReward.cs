using System;

namespace core.config
{
	// Token: 0x02001C91 RID: 7313
	public class AdastraActivityReward : XlsConfigBase<AdastraActivityReward, IAdastraActivityRewardInfo>
	{
		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x0600D3A2 RID: 54178 RVA: 0x003C9930 File Offset: 0x003C7B30
		public override string fileName
		{
			get
			{
				return "AdastraActivityReward";
			}
		}

		// Token: 0x0600D3A3 RID: 54179 RVA: 0x003C9938 File Offset: 0x003C7B38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAdastraActivityRewardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAdastraActivityRewardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D3A4 RID: 54180 RVA: 0x003C998C File Offset: 0x003C7B8C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
