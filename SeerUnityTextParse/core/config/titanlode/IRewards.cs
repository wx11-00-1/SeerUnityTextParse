using System;

namespace core.config.titanlode
{
	// Token: 0x02001F0A RID: 7946
	public class IRewards
	{
		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x0600EDEA RID: 60906 RVA: 0x003F1C5F File Offset: 0x003EFE5F
		// (set) Token: 0x0600EDEB RID: 60907 RVA: 0x003F1C67 File Offset: 0x003EFE67
		public IRewardItem[] reward { get; set; }

		// Token: 0x0600EDEC RID: 60908 RVA: 0x003F1C70 File Offset: 0x003EFE70
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

		// Token: 0x0400F076 RID: 61558
		private bool b;
	}
}
