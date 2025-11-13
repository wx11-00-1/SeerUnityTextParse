using System;

namespace core.config.elvenkingtrial_exchange
{
	// Token: 0x0200204E RID: 8270
	public class IRewards
	{
		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x0600FC91 RID: 64657 RVA: 0x004020C2 File Offset: 0x004002C2
		// (set) Token: 0x0600FC92 RID: 64658 RVA: 0x004020CA File Offset: 0x004002CA
		public IRewardItem[] reward { get; set; }

		// Token: 0x0600FC93 RID: 64659 RVA: 0x004020D4 File Offset: 0x004002D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new IRewardItem[num];
				for (int i = 0; i < num; i++)
				{
					this.reward[i] = new IRewardItem();
					this.reward[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0400F5F7 RID: 62967
		private bool b;
	}
}
